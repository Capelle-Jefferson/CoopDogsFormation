using CoopDogsFormation.Dtos;
using CoopDogsFormation.Models;
using CoopDogsFormation.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoopDogsFormation.Controllers.Admin
{
    public class LoginAdminController : Controller
    {

        /// <summary>
        /// Service utilisateur
        /// </summary>
        public UsersServices UsersServices { get; set; }

        /// <summary>
        /// Contructeur, initialise les données
        /// </summary>
        public LoginAdminController()
        {
            UsersServices = new UsersServices();
        }

        /// <summary>
        /// Affiche le formulaire de connexion administrateur
        /// </summary>
        [Route("/Admin")]
        public IActionResult Index()
        {
            return View("../Admin/AdminUserConnexion");
        }

        /// <summary>
        /// Tentative de connexion, 
        /// redirige l'utilisateur en fonction du résultat
        /// </summary>
        /// <param name="vm">Données de connexion</param>
        [HttpPost]
        public IActionResult Authentification(AuthentificationFormModel vm)
        {
            if (ModelState.IsValid)
            {
                AdminUserDto user = UsersServices.IsAvailableAdminUser(vm.Username, vm.Password);
                if (user == null)
                {
                    ViewBag.NotValidate = true;
                    return View("../Admin/AdminUserConnexion");
                }
                else
                {
                    // création de claims inclus dans une identité
                    List<Claim> claims = new List<Claim> {
                        new Claim(ClaimTypes.Name, user.Username),
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                        new Claim(ClaimTypes.Role, "Admin"),
                    };
                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    // Authentification de l'utilisateur
                    HttpContext.SignInAsync(new ClaimsPrincipal(identity));
                    return Redirect("/Admin/UserList");
                }
            }
            return View("../Admin/AdminUserConnexion");
        }

        [Route("/Admin/Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return View("../Admin/AdminUserConnexion");
        }
    }
}
