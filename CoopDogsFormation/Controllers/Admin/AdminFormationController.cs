using CoopDogsFormation.Models;
using CoopDogsFormation.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Controllers.Admin
{
    [Authorize(Roles = "Admin")]
    public class AdminFormationController : Controller
    {
        public FormationsServices FormationsServices { get; set; }

        public AdminFormationController()
        {
            FormationsServices = new FormationsServices();
        }

        [Route("/Admin/Formations")]
        public IActionResult Index()
        {
            ViewBag.Formations = FormationsServices.GetAdminFormation();
            return View("../Admin/AdminFormation");
        }

        public IActionResult AddFormation(AddFormationFormModel formation)
        {
            if (ModelState.IsValid)
            {
                Tuple<bool, String> res = FormationsServices.AddFormation(formation);
                if (res.Item1)
                    ViewBag.AlertType = "success";
                else
                    ViewBag.AlertType = "danger";
                ViewBag.AlertMsg = res.Item2;
            }
            return Index();
        }

        public IActionResult DeleteFormation(int id)
        {
            Tuple<bool, string> res = FormationsServices.DeleteFormation(id);
            if (res.Item1)
                ViewBag.AlertType = "success";
            else
                ViewBag.AlertType = "danger";
            ViewBag.AlertMsg = res.Item2;
            return Index();
        }
    }
}
