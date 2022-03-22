using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Dtos
{
    public class AdminChapterFormationDto
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
    }
}
