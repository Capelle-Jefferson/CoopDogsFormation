using CoopDogsFormation.Dtos;
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
    public class UserListController : AbtractController
    {
        public UsersServices UsersServices { get; set; }
        public UserFormationServices UserFormationServices { get; set; }
        public UserListController()
        {
            UsersServices = new UsersServices();
            UserFormationServices = new UserFormationServices();
        }

        /// <summary>
        /// Affichage de la liste des utilisateurs
        /// </summary>
        /// <returns></returns>
        [Route("Admin/UserList")]
        public IActionResult Index()
        {
            ViewBag.Users = UsersServices.GetUsers();
            return View("../Admin/UserList");
        }

        /// <summary>
        /// Ajouter un utilisateur
        /// </summary>
        /// <param name="user">Utilisateur à ajouter</param>
        public IActionResult AddUser(AddUserFormModel user)
        {
            if (ModelState.IsValid)
            {
                Tuple<bool, String> res = UsersServices.AddUsers(user);
                if (res.Item1)
                    ViewBag.AlertType = "success";
                else
                    ViewBag.AlertType = "danger";
                ViewBag.AlertMsg = res.Item2;
            }
            return Index();
        }

        /// <summary>
        /// Supprime l'utilisateur
        /// </summary>
        /// <param name="id">identifiant de l'utilisateur à supprimer</param>
        public IActionResult DeleteUser(int id)
        {
            Tuple<bool, string> res = UsersServices.DeleteUser(id);
            if (res.Item1)
                ViewBag.AlertType = "success";
            else
                ViewBag.AlertType = "danger";
            ViewBag.AlertMsg = res.Item2;
            return Index();
        }

        public IActionResult GoUpdateUser(int id)
        {
            ViewBag.User = UsersServices.GetUser(id);
            return View("../Admin/UserUpdate");
        }

        public IActionResult UpdateUser(int id, UpdateUserFormModel user)
        {
            if (ModelState.IsValid)
            {
                Tuple<bool, String> res = UsersServices.UpdateUser(id, user);
                if (res.Item1)
                    ViewBag.AlertType = "success";
                else
                    ViewBag.AlertType = "danger";
                ViewBag.AlertMsg = res.Item2;
            }
            else
            {
                return GoUpdateUser(id);
            }
            return Index();
        }


        public IActionResult GoFormationUser(int id)
        {
            ViewBag.User = UsersServices.GetUser(id);
            Tuple<List<FormationDto>, List<FormationDto>> formations =
                UserFormationServices.GetAdminFormationForUser(id);
            ViewBag.AccessibleFormations = formations.Item1;
            ViewBag.NotAccessibleFormations = formations.Item2;

            return View("../Admin/FormationsUser");
        }

        public IActionResult AddUserFormation(int idFormation, int idUser)
        {
            Tuple<bool, string> res = UserFormationServices.AddUserFormation(idFormation, idUser);
            AlertMessage(res);
            return GoFormationUser(idUser);
        }

        public IActionResult DeleteUserFormation(int idFormation, int idUser)
        {
            Tuple<bool, string> res = UserFormationServices.DeleteUserFormation(idFormation, idUser);
            AlertMessage(res);
            return GoFormationUser(idUser);
        }

        public IActionResult GoUserTrace(int id)
        {
            ViewBag.User = UsersServices.GetUser(id);
            return View("../Admin/UserTrace");
        }

        public IActionResult UserTrace(int id, UpdateUserTraceFromModel user)
        {
            if (ModelState.IsValid)
            {
                Tuple<bool, String> res = UsersServices.UpdateUserTrace(id, user);
                if (res.Item1)
                    ViewBag.AlertType = "success";
                else
                    ViewBag.AlertType = "danger";
                ViewBag.AlertMsg = res.Item2;
            }
            return GoUserTrace(id);
        }
    }
}
