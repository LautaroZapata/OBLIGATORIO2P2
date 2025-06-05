using Dominio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Rol") == null) return Redirect("/Login/Login");

            return View();
            
        }

        public IActionResult VerPasajes()
        {
            if (HttpContext.Session.GetString("Rol") == null) return Redirect("/Login/Login");
            if (HttpContext.Session.GetString("Rol")  == "Administrador")
            {
                Sistema unS = Sistema.Instancia;
                List<Pasaje> listaP = unS.ListarPasajesPorFecha();
                ViewBag.ListaPasajes = listaP;
                if (listaP.Count == 0)
                {
                    ViewBag.error = "Lista vacia";
                }
            }
            else
            {
                ViewBag.error = "Acceso no autorizado";

            }
            return View("VerPasajesAdm", "Admin");
        }

        public IActionResult VerClientes() 
        {
            if (HttpContext.Session.GetString("Rol") == null) return Redirect("/Login/Login");
            if (HttpContext.Session.GetString("Rol") == "Administrador")
            {
                Sistema unS = Sistema.Instancia;
                List<Cliente> listaC = unS.ListarClientes();
                ViewBag.ListaClientes = listaC;
                if (listaC.Count == 0)
                {
                    ViewBag.error = "Lista vacia";
                }
            }else
            {
                ViewBag.error = "Acceso no autorizado";
            }
            return View("VerClientesAdm", "Admin");


        }

    }
}
