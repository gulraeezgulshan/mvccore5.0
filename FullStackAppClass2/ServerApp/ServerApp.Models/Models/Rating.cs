using ServerApp.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerApp.Models
{
    public class Rating : IEntity
    {
        public long Id { get; set; }
        public int Stars { get; set; }

        [Display(Name = "Product")]
        public long ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
