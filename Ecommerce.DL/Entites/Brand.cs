namespace ECommerce.DL.Entites
{
    public class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; } = null!;
        public string? Description { get; set; }

        // Navigatioanl Property
        public ICollection<Product> Products { get; set; } = new List<Product>();

    }
}
