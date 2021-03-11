using System;
using Microsoft.AspNetCore.Mvc;
namespace Light.Controllers
{
    public class CixController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
