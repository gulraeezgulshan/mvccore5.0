using ServerApp.Data.EFCore;
using ServerApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ServerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : AppController<Employee, EmployeeRepository>
    {
        EmployeeRepository _repository;
        public EmployeesController(EmployeeRepository repository) : base(repository)
        {
            _repository = repository;
        }


    }
}
