using Microsoft.EntityFrameworkCore;

namespace Esigned_MVC.Contexts
{
    public class EsignedDbContext : DbContext
    {
        public EsignedDbContext(DbContextOptions options) : base(options)
        {
        }


    }
}
