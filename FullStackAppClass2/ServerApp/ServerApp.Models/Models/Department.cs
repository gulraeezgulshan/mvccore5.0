using ServerApp.Data;
using System.Collections.Generic;

namespace ServerApp.Models
{
    public class Department : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
    }
}
