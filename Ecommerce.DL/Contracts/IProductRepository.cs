using ECommerce.DL.Entites;

namespace Ecommerce.DL.Contracts
{
    public interface IProductRepository
    {
        public IEnumerable<Product>? GetProducts();
        Product GetProductById(int id);
        Task<int> AddProductAsync(Product product);
    }
}
