using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Models
{
    public class AddFormationFormModel
    {
        /// <summary>
        /// Titre de la formation
        /// </summary>
        [Required(ErrorMessage = "Nom d'utilisateur obligatoire")]
        public string Title { get; set; }

        /// <summary>
        /// Description de la formation
        /// </summary>
        public string Description { get; set; }
    }
}
