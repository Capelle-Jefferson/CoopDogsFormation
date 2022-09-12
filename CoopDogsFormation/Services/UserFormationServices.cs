using CoopDogsFormation.Dtos;
using CoopDogsFormation.Mappers;
using CoopDogsFormation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Services
{
    public class UserFormationServices
    {
        public dogsformationsContext Context { get; set; }

        public UserFormationServices()
        {
            Context = new dogsformationsContext();
        }

        /// <summary>
        /// Retourne les formations accessibles et les formations non accessibles
        /// </summary>
        /// <param name="userId">Identifiant de l'utilisateur</param>
        /// <returns>item1 formation accéssible, item 2 non accéssible</returns>
        public Tuple<List<FormationDto>, List<FormationDto>> GetAdminFormationForUser(int userId)
        {
            // Récupération des identifiants des formations accéssibles par l'utilisateur
            List<int> formationsId = Context.UserFormations
                .Where(uf => uf.IdUser == userId)
                .Select(uf => uf.IdFormation).ToList();

            // Récupération de toutes les formations
            List<FormationDto> formations = Context.Formations
                .Select(FormationMapper.ConvertWithoutFormationsToDto)
                .ToList();

            return new Tuple<List<FormationDto>, List<FormationDto>>(
                formations.Where(f => formationsId.Contains(f.IdFormations)).ToList(),
                formations.Where(f => !formationsId.Contains(f.IdFormations)).ToList());
        }

        public List<FormationDto> GetFormationForUser(int userId)
        {
            return GetAdminFormationForUser(userId).Item1;
        }

        public Tuple<bool, string> AddUserFormation(int idFormation, int idUser)
        {
            try
            {
                Context.UserFormations.Add(new UserFormation { 
                    IdFormation = idFormation,
                    IdUser = idUser,
                    CreatedDate = DateTime.Now,
                });
                Context.SaveChanges();
            }
            catch
            {
                return new Tuple<bool, string>(false, "Une erreur est survenue :'( ");
            }

            return new Tuple<bool, string>(true, "La formation à bien été ajouté !");
        }

        public Tuple<bool, string> DeleteUserFormation(int idFormation, int idUser)
        {
            try
            {
                UserFormation userFormation =
                    Context.UserFormations.First(uf => uf.IdFormation == idFormation && uf.IdUser == idUser);
                Context.UserFormations.Remove(userFormation);
                Context.SaveChanges();
            }
            catch
            {
                return new Tuple<bool, string>(false, "Une erreur est survenue :'( ");
            }

            return new Tuple<bool, string>(true, "La formation à bien été supprimé !");
        }
    }
}
