using Ecommerce.BL.DTOs;

namespace Ecommerce.BL.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetAllProducts();
        ProductDTO GetProductById(int id);
        Task<bool> AddProduct(ProductDTO productDTO);
    }
}
