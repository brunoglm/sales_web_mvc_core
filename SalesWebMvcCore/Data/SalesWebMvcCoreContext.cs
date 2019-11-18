using Microsoft.EntityFrameworkCore;

namespace SalesWebMvcCore.Models
{
    public class SalesWebMvcCoreContext : DbContext
    {
        public SalesWebMvcCoreContext (DbContextOptions<SalesWebMvcCoreContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
