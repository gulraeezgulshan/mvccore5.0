using ServerApp.Models;
using ServerApp.Models.EFCore;

namespace ServerApp.Data.EFCore
{
    public class EmployeeRepository : Repository<Employee, AppDbContext>
    {
        AppDbContext _context;
        public EmployeeRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
