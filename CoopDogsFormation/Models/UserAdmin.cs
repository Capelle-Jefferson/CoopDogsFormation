using System;
using System.Collections.Generic;

#nullable disable

namespace CoopDogsFormation.Models
{
    public partial class UserAdmin
    {
        /// <summary>
        /// Identifiant
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
    }
}
