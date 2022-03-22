using System;
using System.Collections.Generic;

#nullable disable

namespace CoopDogsFormation.Models
{
    public partial class UserFormation
    {
        /// <summary>
        /// Identifiant de l'utilisateur 
        /// </summary>
        public int IdUser { get; set; }

        /// <summary>
        /// Identifiant de la formation
        /// </summary>
        public int IdFormation { get; set; }

        /// <summary>
        /// Formation accéssible par l'uitlisateur
        /// </summary>
        public virtual Formation IdFormationNavigation { get; set; }

        /// <summary>
        /// Utilisateur ayant accès à la formation
        /// </summary>
        public virtual User IdUserNavigation { get; set; }
    }
}
