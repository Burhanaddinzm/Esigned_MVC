using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Esigned_MVC.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
