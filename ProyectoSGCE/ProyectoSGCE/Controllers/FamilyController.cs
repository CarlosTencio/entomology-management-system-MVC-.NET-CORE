using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoSGCE.Models;
using System.Threading.Tasks;

namespace ProyectoSGCE.Controllers
{
    public class FamilyController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SearchView()
        {
            if (HttpContext.Session.GetString("User") != null) { 
                return View();
              }
              return RedirectToAction("Login","User");
        }
        [HttpPost]
        public async Task<IActionResult> SearchFamilyView(string family)
        {
            if (HttpContext.Session.GetString("User") != null)
            {
                FamilyModel model = new FamilyModel();
                var families = await model.GetFamilyAsync(family);
                ViewBag.Families = families; // Asignar los pedidos a ViewBag.Families
                ViewBag.Name = family;
                return View("SearchFamilyView");
            }
            return RedirectToAction("RedirectLogin", "User");
        }
        public async Task<IActionResult> SearchFamilyDesc(string familyDesc)
        {
            if (HttpContext.Session.GetString("User") != null)
            {
                FamilyModel model = new FamilyModel();
                var families = await model.GetFamiliesDescAsync(familyDesc);
                ViewBag.Families = families; // Asignar los pedidos a ViewBag.Families
                ViewBag.Name = familyDesc;
                return View("SearchFamilyView");
            }
            return RedirectToAction("Login", "User");
        }
    }
}
