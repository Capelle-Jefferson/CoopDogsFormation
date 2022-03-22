using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Dtos
{
    /// <summary>
    /// Représentation d'un utilisateur
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// Identifiant de l'utilisateur 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom d'utilisateur 
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Nom
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Prénom 
        /// </summary>
        public string Lastname { get; set; }
    }
}
