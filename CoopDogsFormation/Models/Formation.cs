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

        public int IdFormations { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<ChapterFormation> ChapterFormations { get; set; }
        public virtual ICollection<UserFormation> UserFormations { get; set; }
    }
}
