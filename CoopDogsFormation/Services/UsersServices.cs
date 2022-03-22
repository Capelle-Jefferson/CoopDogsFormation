using CoopDogsFormation.Dtos;
using CoopDogsFormation.Mappers;
using CoopDogsFormation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoopDogsFormation.Services
{
    /// <summary>
    /// Service des comptes utilisateurs
    /// </summary>
    public class UsersServices
    {
        public dogsformationsContext Context { get; set; }

        public UsersServices()
        {
            Context = new dogsformationsContext();
        }

        #region Login
        /// <summary>
        /// Récupère le user à l'aide du nom d'utilisateur et le mot de passe, si aucun compte trouvé alors retourne null
        /// </summary>
        /// <param name="username">Nom d'utilisateur</param>
        /// <param name="password">Mot de passe</param>
        /// <returns>null si aucun utilisateur trouvé, sinon retourne l'utilisateur</returns>
        public UserDto IsAvailableUser(string username, string password)
        {
            User user = Context.Users.SingleOrDefault(user => user.Username == username);
            if (user == null)
                return null;
            else if (!VerifyHash(password, user.Password))
                return null;
            else
                return UserMapper.ConvertUserModelToDto(user);
        }

        /// <summary>
        /// Récupère le user à l'aide du nom d'utilisateur et le mot de passe, si aucun compte trouvé alors retourne null
        /// </summary>
        /// <param name="username">Nom d'utilisateur</param>
        /// <param name="password">Mot de passe</param>
        /// <returns>null si aucun utilisateur trouvé, sinon retourne l'utilisateur</returns>
        public AdminUserDto IsAvailableAdminUser(string username, string password)
        {
            UserAdmin user = Context.UserAdmins.SingleOrDefault(user => user.Username == username);
            if (user == null)
                return null;
            else if (!VerifyHash(password, user.Password))
                return null;
            else
                return UserMapper.ConvertAdminUserModelToDto(user);
        }
        #endregion Login

        #region Get
        /// <summary>
        /// Retorune la liste des utilisateurs
        /// </summary>
        public List<UserDto> GetUsers()
        {
            return Context.Users.Select(user => user).ToList()
                .Select(user => UserMapper.ConvertUserModelToDto(user))
                .ToList();
        }

        public UserDto GetUser(long id)
        {
            return UserMapper.ConvertUserModelToDto(
                Context.Users.FirstOrDefault(user => user.Id == id));
        }
        #endregion Get

        public Tuple<bool, string> AddUsers(AddUserFormModel user)
        {
            user.Password = EncodingPassword(user.Password);
            try
            {
                Context.Users.Add(UserMapper.ConvertAddUserFormModelToUser(user));
                Context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                return new Tuple<bool, string>(false, "Nom d'utilisateur déjà existant");
            }
            return new Tuple<bool, string>(true, "L'utilisateur à bien été ajouté !");
        }

        public Tuple<bool, string> DeleteUser(int id)
        {
            try
            {
                Context.Users.Remove(Context.Users.FirstOrDefault(user => user.Id == id));
                Context.SaveChanges();
            }
            catch
            {
                return new Tuple<bool, string>(true, "Une erreur est survenue :'( ");
            }
            return new Tuple<bool, string>(true, "L'utilisateur à bien été supprimé !");
        }

        #region Crypt
        /// <summary>
        ///     Crypte le mot de passe pour l'enregistrer dans la base de données
        /// </summary>
        /// <param name="user">Objet User contenant le mot de passe</param>
        /// <returns>le mot de passe crypté</returns>
        private string EncodingPassword(string password)
        {
            string passwordHash = "";
            using (SHA256 sha256Hash = SHA256.Create())
            {
                passwordHash = GetHash(sha256Hash, password);
            }
            return passwordHash;
        }

        /// <summary>
        ///     Crypte input
        /// </summary>
        /// <param name="hashAlgorithm">HashAlgorithm</param>
        /// <param name="input">mot à crypter</param>
        /// <returns>input crypté</returns>
        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        /// <summary>
        ///     Verifie si stringNonCrypter est égal à hash
        /// </summary>
        /// <param name="hashAlgorithm">HashAlgorithm</param>
        /// <param name="stringNonCrypter">Mot non hasher à vérifier</param>
        /// <param name="hash">Mot hasher</param>
        /// <returns></returns>
        private static bool VerifyHash(string stringNonCrypter, string hash)
        {
            StringComparer comparer;
            string hashOfInput;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                hashOfInput = GetHash(sha256Hash, stringNonCrypter);
                comparer = StringComparer.OrdinalIgnoreCase;
            }
            return comparer.Compare(hashOfInput, hash) == 0;
        }
        #endregion Crypt
    }
}
