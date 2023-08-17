using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoSGCE.Models;
using System.Threading.Tasks;

namespace ProyectoSGCE.Controllers
{
    public class PlantController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
        public async Task<IActionResult> SearchPlantView(string plant)
        {


            if (HttpContext.Session.GetString("User") != null)
            {
                PlantModel model = new PlantModel();
                var plants = await model.GetPlantsAsync(plant);
                ViewBag.Plants = plants; // Asignar los pedidos a ViewBag.Orders
                return View("SearchPlantView");
            }
            return RedirectToAction("RdirectLogin", "User");
        }
    }
}
