using Class2.Models;
using Class2.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class2.Data
{
    public class EmployeeRepository : Repository<Employee, ApplicationDbContext>
    {

        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
            
        }

    }

}
