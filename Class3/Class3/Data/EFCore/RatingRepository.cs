using Class3.Models;
using Class3.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class3.Data.EFCore
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
