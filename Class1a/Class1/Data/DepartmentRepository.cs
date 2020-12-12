using Class1a.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class1a.Data
{
    public class DepartmentRepository : Repository<Department, ApplicationDbContext>
    {
        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
