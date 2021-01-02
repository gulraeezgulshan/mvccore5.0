using ServerApp.Data.EFCore;
using ServerApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ServerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : AppController<Department, DepartmentRepository>
    {
        DepartmentRepository _repository;
        public DepartmentsController(DepartmentRepository repository) : base(repository)
        {
            _repository = repository;
        }


    }
}
