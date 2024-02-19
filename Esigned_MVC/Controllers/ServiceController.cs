using Esigned.Core.Entities;
using Esigned_MVC.Contexts;
using Esigned_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Esigned_MVC.Controllers
{
    public class ServiceController : Controller
    {
        private readonly EsignedDbContext _esignedDbContext;

        public ServiceController(EsignedDbContext esignedDbContext)
        {
            _esignedDbContext = esignedDbContext;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Service> services = await _esignedDbContext.Services
                .Where(m => !m.IsDeleted)
                .AsNoTracking()
                .ToListAsync();

            return View(services);
        }
    }
}
