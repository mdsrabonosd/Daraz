using Microsoft.AspNetCore.Mvc;

namespace daraz.Controllers
{
    public class SaleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Megasale()
        {
            return View();
        }
        public IActionResult partial()
        {
            return View();
        }
    }
}
