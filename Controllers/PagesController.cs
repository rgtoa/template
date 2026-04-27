using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCore_Exercise10.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Faqs()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
