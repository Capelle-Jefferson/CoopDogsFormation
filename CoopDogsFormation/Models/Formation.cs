using System;
using System.Collections.Generic;

#nullable disable

namespace CoopDogsFormation.Models
{
    public partial class Formation
    {
        public Formation()
        {
            ChapterFormations = new HashSet<ChapterFormation>();
            UserFormations = new HashSet<UserFormation>();
        }

        /// <summary>
        /// Identifiant de la formation
        /// </summary>
        public int IdFormations { get; set; }

        /// <summary>
        /// Titre de la formation
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Description de la formation
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Liste des chapitres appartenant à la formation
        /// </summary>
        public virtual ICollection<ChapterFormation> ChapterFormations { get; set; }

        /// <summary>
        /// Liste des utilisateurs ayant accès à la formation
        /// </summary>
        public virtual ICollection<UserFormation> UserFormations { get; set; }
    }
}
