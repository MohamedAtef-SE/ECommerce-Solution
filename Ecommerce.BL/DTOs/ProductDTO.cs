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
        
        // Foreign Key
        public int? CategoryId { get; set; }

        // Navigational Property
        public Category? Category { get; set; } = new Category();
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
