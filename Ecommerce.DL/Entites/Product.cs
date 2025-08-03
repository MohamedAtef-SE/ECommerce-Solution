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
        public int? CategoryId { get; set; }
        
        // Navigational Property
        public Category? Category { get; set; } = new Category();

        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
