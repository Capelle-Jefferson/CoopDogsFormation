using System;
using System.Collections.Generic;

#nullable disable

namespace CoopDogsFormation.Models
{
    public partial class UserFormation
    {
        public int IdUser { get; set; }
        public int IdFormation { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Formation IdFormationNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
