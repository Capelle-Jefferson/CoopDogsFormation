using System;
using System.Collections.Generic;

#nullable disable

namespace CoopDogsFormation.Models
{
    public partial class User
    {
        public User()
        {
            UserFormations = new HashSet<UserFormation>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool AllFormationAccess { get; set; }
        public string TraceNote { get; set; }

        public virtual ICollection<UserFormation> UserFormations { get; set; }
    }
}
