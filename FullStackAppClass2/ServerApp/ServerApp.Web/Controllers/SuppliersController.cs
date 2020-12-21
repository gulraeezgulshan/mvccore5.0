using ServerApp.Data.EFCore;
using ServerApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ServerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : AppController<Supplier, SupplierRepository>
    {
        SupplierRepository _repository;
        public SuppliersController(SupplierRepository repository) : base(repository)
        {
            _repository = repository;
        }

    }
}
