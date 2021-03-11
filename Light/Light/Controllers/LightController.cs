using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Light.Models;

namespace Light.Controllers
{
    public class LightController: Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Oneus()
        {
            return View();
        }
        public IActionResult Ateez()
        {
            return View();
        }
    }
}
