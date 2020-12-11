using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Class1.Models
{
    public class Department
    {

        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string ShortName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
    }
}
