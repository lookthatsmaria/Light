using System;
using System.Collections.Generic;
using Light.Models;
using Microsoft.AspNetCore.Mvc;

namespace Light.Controllers
{
    public class OneusController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Beginner()
        {
            return View();
        }
        public IActionResult Ravn()
        {
            return View();
        }
        public IActionResult Fancafe()
        {
            return View();
        }
    }
}


