using Esigned.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Esigned_MVC.Contexts
{
    public class EsignedDbContext : DbContext
    {
        public EsignedDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; } = null!;
        public DbSet<Service> Services { get; set; } = null!;
        public DbSet<Setting> Settings { get; set; } = null!;
        public DbSet<Position> Positions { get; set; } = null!;
        public DbSet<Portfolio> Portfolios { get; set; } = null!;
        public DbSet<Testimonial> Testimonials { get; set; } = null!;
    }
}
