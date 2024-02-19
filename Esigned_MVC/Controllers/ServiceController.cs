using Microsoft.AspNetCore.Mvc;

namespace Esigned_MVC.Controllers
{
    public class ServiceController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
