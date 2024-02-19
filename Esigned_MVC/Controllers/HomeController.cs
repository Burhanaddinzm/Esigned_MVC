using Esigned_MVC.Contexts;
using Esigned_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Esigned_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly EsignedDbContext _esignedDbContext;

        public HomeController(EsignedDbContext esignedDbContext)
        {
            _esignedDbContext = esignedDbContext;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();

            homeViewModel.Sliders = await _esignedDbContext.Sliders
                .Where(m=>!m.IsDeleted)
                .AsNoTracking()
                .ToListAsync(); 

            homeViewModel.Services = await _esignedDbContext.Services
                .Where(m=>!m.IsDeleted)
                .AsNoTracking()
                .ToListAsync();

            return View(homeViewModel);
        }
    }
}
