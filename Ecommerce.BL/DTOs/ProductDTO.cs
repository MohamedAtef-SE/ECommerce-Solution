using ECommerce.DL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BL.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string ProuductName { get; set; } = null!;
        public decimal Price { get; set; }
        public string? Description { get; set; }
 
        public int? CategoryId { get; set; }

        public int BrandId { get; set; }
    }
}
