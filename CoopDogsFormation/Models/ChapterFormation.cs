using System;
using System.Collections.Generic;

#nullable disable

namespace CoopDogsFormation.Models
{
    public partial class ChapterFormation
    {
        /// <summary>
        /// Identifiant du chapitre 
        /// </summary>
        public int IdChapter { get; set; }

        /// <summary>
        /// Titre du chapitre
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Description du chapitre 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Nom / url de la vidéo 
        /// </summary>
        public string UrlVideo { get; set; }

        /// <summary>
        /// Identifiant de la formation 
        /// </summary>
        public int IdFormation { get; set; }

        /// <summary>
        /// Objet formation 
        /// </summary>
        public virtual Formation IdFormationNavigation { get; set; }
    }
}
