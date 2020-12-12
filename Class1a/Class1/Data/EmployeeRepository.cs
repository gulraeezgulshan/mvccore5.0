using Class1a.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class1a.Data
{
    public class EmployeeRepository : Repository<Employee, ApplicationDbContext>
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
