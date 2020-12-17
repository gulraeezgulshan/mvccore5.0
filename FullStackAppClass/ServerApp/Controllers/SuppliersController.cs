using ServerApp.Data.EFCore;
using ServerApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
