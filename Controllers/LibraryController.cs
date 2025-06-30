using Microsoft.AspNetCore.Mvc;

namespace daraz.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult Admit()
        {
            return View();
        }
    }
}
