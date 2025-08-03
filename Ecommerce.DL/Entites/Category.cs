namespace ECommerce.DL.Entites
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }

        // Navigational Property
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
