using AutoMapper;
using Ecommerce.BL.DTOs;
using Ecommerce.DL;
using Ecommerce.DL.Contracts;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BL.Services
{
    public class ProductService
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
            // logic...............
            // ....................
            var products = _productRepository.GetProducts();
            if (products == null) return new List<ProductDTO>();

            var productsDTOlist = _mapper.Map< IEnumerable<ProductDTO> >(products);


            //foreach (var product in products)
            //{
            //    ProductDTO productDTO = new ProductDTO()
            //    {
            //        Id = product.Id,
            //        ProuductName = product.ProuductName,
            //        BrandId = product.BrandId,
            //        CategoryId = product.CategoryId,
            //        Description = product.Description,
            //        Price = product.Price,
            //    };

            //    productsDTOlist.Add(productDTO);
            //}

            return productsDTOlist;

        }
    }
}
