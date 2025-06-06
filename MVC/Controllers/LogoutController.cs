﻿using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Login");

        }
    }
}
