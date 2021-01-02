using ServerApp.Models;
using ServerApp.Models.EFCore;

namespace ServerApp.Data.EFCore
{
    public class DepartmentRepository : Repository<Department, AppDbContext>
    {
        AppDbContext _context;
        public DepartmentRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}