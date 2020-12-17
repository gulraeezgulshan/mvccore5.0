using ServerApp.Models;
using ServerApp.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Data.EFCore
{
    public class RatingRepository : Repository<Rating, AppDbContext>
    {
        AppDbContext _context;
        public RatingRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
