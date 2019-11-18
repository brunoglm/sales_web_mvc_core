using Microsoft.EntityFrameworkCore;
using SalesWebMvcCore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcCore.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcCoreContext _context; 

        public DepartmentService(SalesWebMvcCoreContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
