using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class PasajeController : Controller
    {
        public IActionResult ComprarPasaje(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}
