using CoopDogsFormation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Dtos
{
    public class AdminFormationDto
    {

        public AdminFormationDto()
        {
            ChapterFormations = new List<AdminChapterFormationDto>();
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

        /// <summary>
        /// Liste des chapitres appartenant à la formation
        /// </summary>
        public virtual ICollection<AdminChapterFormationDto> ChapterFormations { get; set; }

        /// <summary>
        /// Liste des utilisateurs ayant accès à la formation
        /// </summary>
        public virtual ICollection<UserDto> Users { get; set; }
    }
}
