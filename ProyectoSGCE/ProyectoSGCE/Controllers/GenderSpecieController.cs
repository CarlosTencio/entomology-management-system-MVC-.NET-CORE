using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoSGCE.Models;
using System.Threading.Tasks;

namespace ProyectoSGCE.Controllers
{
    public class GenderSpecieController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("User") != null)
            {
                return View();
            }
            return RedirectToAction("Login", "User");
        }
        public IActionResult SearchView()
        {
            if (HttpContext.Session.GetString("User") != null)
            {
                return View();

            }
            return RedirectToAction("Login", "User");
        }
        [HttpPost]
        public async Task<IActionResult> SearchGenderSpecieView(string genderSpecie)
        {
            if (HttpContext.Session.GetString("User") != null)
            {
                GenderSpecieModel model = new GenderSpecieModel();
                var genderSpecies = await model.GetGenderSpeciesync(genderSpecie);
                ViewBag.Genders = genderSpecies; // Asignar los pedidos a ViewBag.Orders
                return View("SearchGenderSpecieView");
            }
            return RedirectToAction("RedirectLogin", "User");
        }
    }
}
