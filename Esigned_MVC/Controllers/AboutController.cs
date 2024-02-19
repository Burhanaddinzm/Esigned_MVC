using Microsoft.AspNetCore.Mvc;

namespace Esigned_MVC.Controllers
{
    public class AboutController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Portfolio()
        {
            return View();
        }
    }
}
