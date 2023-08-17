using ProyectoSGCE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis.Operations;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Authorization;

namespace ProyectoSGCE.Controllers
{
    public class UserController : Controller
    {
        private IConfiguration Configuration { get; }

        public UserController(IConfiguration configuration)
        {

            Configuration = configuration;
        }
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult RedirectLogin()
        {
            return View("Login");
        }
        [HttpGet]

        public IActionResult Login()
        {
 
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            Response.Cookies.Delete("username");
            return RedirectToAction("Login", "User"); // Reemplaza "NombreDelControlador" con el nombre real de tu controlador de inicio de sesión
        }
        [HttpPost]
        public async Task<IActionResult> LoginUser(string username, string password)
        {
            if (ModelState.IsValid)
            {
                UserModel model = new UserModel(Configuration);
                User newUser = new User(username, password);
                int exists = model.IsUsernameAlreadyExists(newUser);

                if (exists ==1)
                {
                    HttpContext.Session.SetString("User", username + "");
                    string name = HttpContext.Session.GetString("User");
                    Response.Cookies.Append("username", username, new CookieOptions
                    {
                        Expires = DateTime.Now.AddDays(1), // Define una fecha de vencimiento para la cookie
                        SameSite = SameSiteMode.Strict, // Controla las políticas de SameSite para la cookie
                                                        // Otros parámetros de configuración de la cookie (opcional)
                    });
                    return View("Index");
                }
                else {
                    return View("LoginError");
                }

            }
            return View("Login");

        }

        public IActionResult Register()
        {
           TempData["RegistroExitoso"] = "empty";
            return View();
            
        }

        [HttpPost]
        public IActionResult RegisterUser(User user)
        {
            if (ModelState.IsValid)
            {
                UserModel model = new UserModel(Configuration);
                bool confirm=model.RegisterUser(user);
                if (confirm)
                {
                    TempData["RegistroExitoso"] = true;
                    return View("Register");
                }
                TempData["RegistroExitoso"] = false;
            }
            return View("Register");
        }

        public IActionResult RecordComment(string comment,int id_specimen,int specie) {
            UserModel model=new UserModel(Configuration);
            string name= Request.Cookies["username"];
            CommentSpecimen commentSpecimen = new CommentSpecimen(name,comment,(int)id_specimen);
            model.RecordComment(commentSpecimen);
            TempData["RegistroExitoso"] = true;
            return RedirectToAction("RedirectSearch", "Specimen", new { specimen = specie });
        }
    }
}
