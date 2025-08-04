using System.ComponentModel.DataAnnotations;

namespace ECommerce.DL.Entites
{
    // How to Configure The Models to be Tables in DB in transformation way using ORM EF Core ?
    // 01. By Convension.
    public class Product
    {
        public int Id { get; set; }
        public string ProuductName { get; set; } = null!;
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? SeUserId { get; set; }

        // Foreign Key
        public int? CategoryId { get; set; }
        
        // Navigational Property
        public Category? Category { get; set; }

        public int? BrandId { get; set; }
        public Brand? Brand { get; set; }
    }
}
