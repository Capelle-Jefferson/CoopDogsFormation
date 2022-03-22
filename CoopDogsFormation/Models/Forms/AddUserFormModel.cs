using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Models
{
    public class AddUserFormModel
    {
        [Required(ErrorMessage = "Nom d'utilisateur obligatoire")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mot de passe obligatoire")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmation du mot de passe obligatoire")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Les mots de passe ne sont pas identique")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Nom obligatoire")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Prénom d'utilisateur obligatoire")]
        public string Lastname { get; set; }
    }
}
