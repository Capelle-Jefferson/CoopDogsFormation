using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Controllers
{
    [Authorize]
    public class FormationController : Controller
    {
        /// <summary>
        /// Affiche la liste des formations de l'utilisateur connecté
        /// </summary>
        [Route("Formation/FormationList")]
        public IActionResult FormationList()
        {
            return View();
        }
    }
}
