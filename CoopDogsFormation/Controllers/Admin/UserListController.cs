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
    public class UserListController : Controller
    {
        public UsersServices UsersServices { get; set; }
        public UserListController()
        {
            UsersServices = new UsersServices();
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
    }
}
