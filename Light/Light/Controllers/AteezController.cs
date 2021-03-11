using System;
using System.Collections.Generic;
using Light.Models;
using Microsoft.AspNetCore.Mvc;
namespace Light.Controllers
{
    public class AteezController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Beginner()
        {
            return View();
        }
        public IActionResult HongJoong()
        {
            return View();
        }
    }
}
