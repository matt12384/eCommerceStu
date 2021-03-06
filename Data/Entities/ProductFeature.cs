using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eCommerceStu.Data.Entities
{
    public class ProductFeature
    {
        public int ProductId { get; set; }
        public int FeatureId { get; set; }
        [Required]
        public Product Product { get; set; }
        public Feature Feature { get; set; }
    }
}