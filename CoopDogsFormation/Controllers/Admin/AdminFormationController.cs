using CoopDogsFormation.Dtos;
using CoopDogsFormation.Models;
using CoopDogsFormation.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Ubiety.Dns.Core;

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

        #region Formations
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

        public IActionResult GoUpdateFormation(int id)
        {
            FormationDto f = FormationsServices.GetAdminFormation(id);
            f.Description = f.Description;
            ViewBag.Formation = f;
            return View("../Admin/AdminFormationUpdate");
        }

        public IActionResult UpdateFormation(int id, AddFormationFormModel formation)
        {
            formation.Description = formation.Description;
            Tuple<bool, string> res = FormationsServices.UpdateFormation(id, formation);
            if (res.Item1)
                ViewBag.AlertType = "success";
            else
                ViewBag.AlertType = "danger";
            ViewBag.AlertMsg = res.Item2;
            return Index();
        }
        #endregion Formations


        #region Chapitres
        [Route("/Admin/Formations/Details")]
        public IActionResult Details(int id)
        {
            ViewBag.Formation = FormationsServices.GetAdminFormation(id);
            return View("../Admin/AdminFormationDetails");
        }

        public IActionResult AddChapter(AddChapterFormationFormModel chapter, int id)
        {
            if (ModelState.IsValid)
            {
                FormationDto formation = FormationsServices.GetAdminFormation(id);
                chapter.IdFormation = id;
                chapter.Number = formation.ChapterFormations.Count() + 1;
                Tuple<bool, String> res = FormationsServices.AddChapter(chapter);
                if (res.Item1)
                    ViewBag.AlertType = "success";
                else
                    ViewBag.AlertType = "danger";
                ViewBag.AlertMsg = res.Item2;
            }
            return Details(id);
        }


        public IActionResult DeleteChapter(int idChapter, int idFormation)
        {
            Tuple<bool, string> res = FormationsServices.DeleteChapter(idChapter, idFormation);
            if (res.Item1)
                ViewBag.AlertType = "success";
            else
                ViewBag.AlertType = "danger";
            ViewBag.AlertMsg = res.Item2;

            return Details(idFormation);
        }

        public IActionResult GoUpdateChapter(int idChapter)
        {
            ViewBag.Chapter = FormationsServices.GetChapter(idChapter);
            ViewBag.Formation = FormationsServices.GetAdminFormation(ViewBag.Chapter.IdFormation, false);
            return View("../Admin/AdminFormationDetailsUpdate");
        }

        public IActionResult UpdateChapter(int idChapter, int idFormation, AddChapterFormationFormModel model)
        {
            model.IdFormation = idFormation;
            Tuple<bool, string> res = FormationsServices.UpdateChapter(idChapter, model);
            if (res.Item1)
                ViewBag.AlertType = "success";
            else
                ViewBag.AlertType = "danger";
            ViewBag.AlertMsg = res.Item2;
            return Details(model.IdFormation);
        }
        #endregion Chapitres
    }
}
