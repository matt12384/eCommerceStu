using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eCommerceStu.Data.Entities
{
    public class OS
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Product> Product { get; set; } = new List<Product>();
    }
}