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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoopDogsFormation.Controllers
{
    /// <summary>
    /// Controller des utilisateurs
    /// </summary>
    public class UserController : Controller
    {
        /// <summary>
        /// Service utilisateur
        /// </summary>
        public UsersServices UsersServices { get; set; }

        /// <summary>
        /// Contructeur, initialise les données
        /// </summary>
        public UserController()
        {
            UsersServices = new UsersServices();
        }

        /// <summary>
        /// Affiche la page de connexion
        /// </summary>
        [Route("Connexion")]
        public IActionResult Index()
        {
            return View("UserConnexion");
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
                UserDto user = UsersServices.IsAvailableUser(vm.Username, vm.Password);
                if (user == null)
                {
                    ViewBag.NotValidate = true;
                    return View("UserConnexion");
                }
                else
                {
                    // création de claims inclus dans une identité
                    List<Claim> claims = new List<Claim> {
                        new Claim(ClaimTypes.Name, user.Username),
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    };
                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    // Authentification de l'utilisateur
                    HttpContext.SignInAsync(new ClaimsPrincipal(identity));
                    return Redirect("/Formation/FormationList");
                }
            }
            return View("UserConnexion");
        }

        [Route("/AccessDenied")]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [Route("/Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return Redirect("/Connexion");
        }
    }
}

