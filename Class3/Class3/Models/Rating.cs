using Class3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class3.Models
{
    public class Rating : IEntity
    {
        public long Id { get; set; }
        public int Stars { get; set; }
        public Product Product { get; set; }
    }
}
