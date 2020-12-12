using Class1a.Data;
using Class1a.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class1a.Controllers
{
    [Route("aptech/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {

        private readonly IRepository<Department> _context;

        public DepartmentsController(IRepository<Department> context)
        {
            _context = context;
        }

        // GET: aptech/employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        {
            return await _context.GetAll();
        }

        // GET: api/employees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetDepartment(int id)
        {

            var department = await _context.Get(id);

            if (department == null)
            {
                return NotFound();
            }

            return department;
        }

        // PUT: api/employees/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartment(int id, Department department)
        {
            if (id != department.Id)
            {
                return BadRequest();
            }

            try
            {
                await _context.Put(department);
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentExists(id))
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
        public async Task<ActionResult<Department>> PostDepartment(Department _department)
        {
            var department = await _context.Post(_department);
            return CreatedAtAction("GetDepartment", new { id = department.Id }, department);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var department = await _context.Get(id);

            if (department == null)
            {
                return NotFound();
            }

            await _context.Delete(department);

            return NoContent();
        }

        private bool DepartmentExists(int id)
        {
            return _context.IsExsist(id);
        }
    }
}
