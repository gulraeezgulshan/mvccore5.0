using Class1a.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Class1a.Models
{
    public class Employee : IEntity
    {
        public int Id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Address { get; set; }

        public int Age { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        public string Gender { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        //Navigate Property
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }
}
