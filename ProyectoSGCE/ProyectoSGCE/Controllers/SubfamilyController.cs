using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoSGCE.Models;
using System.Threading.Tasks;

namespace ProyectoSGCE.Controllers
{
    public class SubfamilyController : Controller
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
        public async Task<IActionResult> SearchSubfamilyView(string subfamily)
        {
            if (HttpContext.Session.GetString("User") != null)
            {
                SubfamilyModel model = new SubfamilyModel();
                var subfamilies = await model.GetSubfamilyAsync(subfamily);
                ViewBag.Subfamilies = subfamilies; // Asignar los pedidos a ViewBag.Orders
                 ViewBag.Name = subfamily;
                return View("SearchSubfamilyView");
            }
            return RedirectToAction("Login", "User");

           
        }
        public async Task<IActionResult> SearchSubfamilyDesc(string subfamilyDesc)
        {
            if (HttpContext.Session.GetString("User") != null)
            {
                 SubfamilyModel model = new SubfamilyModel();
            var subfamilies = await model.GetSubfamiliesDescAsync(subfamilyDesc);
            ViewBag.Subfamilies = subfamilies; // Asignar los pedidos a ViewBag.Orders
            ViewBag.Name = subfamilyDesc;
            return View("SearchSubfamilyView"); 
            }
            return RedirectToAction("Login", "User");

           
            
        }
    }
}
