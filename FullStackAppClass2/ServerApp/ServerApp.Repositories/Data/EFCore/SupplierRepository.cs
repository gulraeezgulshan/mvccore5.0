using ServerApp.Models;
using ServerApp.Models.EFCore;

namespace ServerApp.Data.EFCore
{
    public class SupplierRepository : Repository<Supplier, AppDbContext>
    {
        AppDbContext _context;
        public SupplierRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
