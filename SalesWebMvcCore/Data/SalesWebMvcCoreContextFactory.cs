using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SalesWebMvcCore.Models;

namespace SalesWebMvcCore.Data
{
    public class SalesWebMvcCoreContextFactory : IDesignTimeDbContextFactory<SalesWebMvcCoreContext>
    {
        public SalesWebMvcCoreContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SalesWebMvcCoreContext>();
            optionsBuilder.UseMySql("server = localhost; userid = root; password =; database = saleswebmvcappdb");

            return new SalesWebMvcCoreContext(optionsBuilder.Options);
        }
    }
}


