using ServerApp.Data.EFCore;
using ServerApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : AppController<Product, ProductRepository>
    {
        ProductRepository _repository;
        public ProductsController(ProductRepository repository) : base(repository)
        {
            _repository = repository;
        }

        [HttpGet("rel/{id}")]
        public async Task<ActionResult<Product>> GetRelated(int id)
        {
            var entity = await _repository.GetRelated(id);
            if (entity == null)
            {
                return NotFound();
            }
            return entity;
        }

        [HttpGet("rel")]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllRelated (bool related)
        {
            return await _repository.GetAllRelated(related);
        }

    }




}
