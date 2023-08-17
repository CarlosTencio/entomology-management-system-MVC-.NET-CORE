using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoSGCE.Models;
using System.Threading.Tasks;

namespace ProyectoSGCE.Controllers
{
    public class OrderController : Controller
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
        public async Task<IActionResult> SearchOrderView(string order)
        {
            if (HttpContext.Session.GetString("User") != null)
            {
                OrderModel model = new OrderModel();
                var orders = await model.GetOrdersAsync(order);
                ViewBag.Orders = orders;
                 ViewBag.name = order;
                return View("SearchOrderView"); 
            }
            return RedirectToAction("RedirectLogin", "User");
           
        }
        public async Task<IActionResult> SearchOrderDesc(string orderDesc)
        {
            if (HttpContext.Session.GetString("User") != null)
            {
                OrderModel model = new OrderModel();
                var orders = await model.GetOrdersDescAsync(orderDesc);
                ViewBag.Orders = orders; // Asignar los pedidos a ViewBag.Families
                ViewBag.name = orderDesc;
                return View("SearchOrderView");
            }
            return RedirectToAction("RedirectLogin", "User");
        }
    }
}
