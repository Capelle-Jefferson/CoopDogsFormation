using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Models
{
    public class AddChapterFormationFormModel
    {
        /// <summary>
        /// Numéro du chapitre
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Titre du chapitre
        /// </summary>
        [Required(ErrorMessage = "Titre du chapitre obligatoire")]
        public string Title { get; set; }

        /// <summary>
        /// Description du chapitre
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Url de la vidéo
        /// </summary>
        public IFormFile File { get; set; }

        /// <summary>
        /// Identifiant de la formation associé
        /// </summary>
        public int IdFormation { get; set; }

    }
}
