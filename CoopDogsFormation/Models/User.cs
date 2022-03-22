using System;
using System.Collections.Generic;

#nullable disable

namespace CoopDogsFormation.Models
{
    public partial class User
    {
        public User()
        {
            UserFormations = new HashSet<UserFormation>();
        }

        /// <summary>
        /// Identifiant de l'utilisatuer
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom d'utilisateur
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Mot de passe 
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Nom
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Prénom
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// Liste des formations accessibles 
        /// </summary>
        public virtual ICollection<UserFormation> UserFormations { get; set; }
    }
}
