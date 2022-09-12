using CoopDogsFormation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Dtos
{
    public class FormationDto
    {

        public FormationDto()
        {
            ChapterFormations = new List<ChapterFormationDto>();
            Users = new List<UserDto>();
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

        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Liste des chapitres appartenant à la formation
        /// </summary>
        public virtual ICollection<ChapterFormationDto> ChapterFormations { get; set; }

        /// <summary>
        /// Liste des utilisateurs ayant accès à la formation
        /// </summary>
        public virtual ICollection<UserDto> Users { get; set; }
    }
}
