using ServerApp.Models;
using ServerApp.Models.EFCore;

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
