﻿using Microsoft.AspNetCore.Mvc;

namespace E_commerce.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
