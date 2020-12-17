using Class3.Models;
using Class3.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class3.Data.EFCore
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
