using CoopDogsFormation.Dtos;
using CoopDogsFormation.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoopDogsFormation.Controllers
{
    [Authorize]
    public class FormationController : AbtractController
    {
        public UserFormationServices UserFormationServices { get; set; }

        public FormationsServices FormationServices { get; set; }

        public FormationController()
        {
            UserFormationServices = new UserFormationServices();
            FormationServices = new FormationsServices();
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        /// <summary>
        /// Affiche la liste des formations de l'utilisateur connecté
        /// </summary>
        [Route("Formation/FormationList")]
        public IActionResult FormationList()
        {
            ViewBag.Formations = UserFormationServices.GetFormationForUser(GetUserId());
            return View("FormationList");
        }

        [Route("Formation/Formation")]
        public IActionResult ConsultFormation(int id)
        {
            List<FormationDto> formations = UserFormationServices.GetFormationForUser(GetUserId());
            if (formations.Any(f => f.IdFormations == id))
            {
                ViewBag.Formation = FormationServices.GetAdminFormation(id);
                return View();
            }
            else
            {
                return FormationList();
            }
        }
    }
}
