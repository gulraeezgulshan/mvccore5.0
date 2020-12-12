using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Class2.Models;
using Class2.Data;

namespace Class1.Controllers
{
    [Route("aptech/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private readonly IRepository<Employee> _context;

        public EmployeesController(IRepository<Employee> context)
        {
            _context = context;
        }

        // GET: aptech/employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            return await _context.GetAll();
        }

        // GET: api/employees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {

            var employee = await _context.Get(id);

            if (employee == null)
            {
                return NotFound();
            }

            return employee;
        }

        // PUT: api/employees/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, Employee employee)
        {
            if (id != employee.Id)
            {
                return BadRequest();
            }

            try
            {
                await _context.Put(employee);
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Employees
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee _employee)
        {
            var employee = await _context.Post(_employee);
            return CreatedAtAction("GetEmployee", new { id = employee.Id }, employee);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await _context.Get(id);
            
            if (employee == null)
            {
                return NotFound();
            }

            await _context.Delete(employee);
           
            return NoContent();
        }

        private bool EmployeeExists(int id)
        {
            return _context.IsExsist(id);
        }
    }
}
