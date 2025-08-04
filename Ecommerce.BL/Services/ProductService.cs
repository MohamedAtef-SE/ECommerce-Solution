using AutoMapper;
using Ecommerce.BL.DTOs;
using Ecommerce.BL.Interfaces;
using Ecommerce.DL.Contracts;
using ECommerce.DL.Entites;

namespace Ecommerce.BL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            this._productRepository = productRepository;
            _mapper = mapper;
        }

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            var products = _productRepository.GetProducts();
            if (products == null) return new List<ProductDTO>();

            var productsDTOlist = _mapper.Map<IEnumerable<ProductDTO>>(products);
            return productsDTOlist;

        }
        public ProductDTO GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AddProduct(ProductDTO productDTO)
        {
            if (productDTO == null)
            {
                throw new Exception("no product found");
            }
            var newProduct = _mapper.Map<Product>(productDTO);
            var result = await _productRepository.AddProductAsync(newProduct);
            return result > 0;
        }
    }
}
