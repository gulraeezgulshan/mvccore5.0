using ServerApp.Data.EFCore;
using ServerApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ServerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : AppController<Rating, RatingRepository>
    {
        RatingRepository _repository;
        public RatingsController(RatingRepository repository) : base(repository)
        {
            _repository = repository;
        }


    }
}
