using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoSGCE.Models;
using System.Threading.Tasks;

namespace ProyectoSGCE.Controllers
{
    public class SpecieController : Controller
    {
        public IActionResult Index()
        {

            if (HttpContext.Session.GetString("User") != null)
            {
                return View();
            }
            return RedirectToAction("Login", "User");
        }

        [HttpPost]
        public async Task<IActionResult> SearchSpecieView(string specie)
        {
          
            if (HttpContext.Session.GetString("User") != null )
            { 
                SpecieModel model = new SpecieModel();
                var species = await model.GetSpeciesOfGenderync(specie);
                ViewBag.Species = species; // Asignar los pedidos a ViewBag.Species
                return View();
            }
            return RedirectToAction("Login", "User");
        }

    }
}
