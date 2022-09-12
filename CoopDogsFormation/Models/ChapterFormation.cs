using System;
using System.Collections.Generic;

#nullable disable

namespace CoopDogsFormation.Models
{
    public partial class ChapterFormation
    {
        public int IdChapter { get; set; }
        public int ChapterNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UrlVideo { get; set; }
        public int IdFormation { get; set; }

        public virtual Formation IdFormationNavigation { get; set; }
    }
}
