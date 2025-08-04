using Ecommerce.DL.Contracts;
using ECommerce.DL.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDBContext _dbContext;

        public ProductRepository(ApplicationDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IEnumerable<Product>? GetProducts()
        {
            //ApplicationDBContext dbContext = new ApplicationDBContext();

            var products = _dbContext.Products.ToList();
            return products;

        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> AddProductAsync(Product product)
        {
            var  result  = await _dbContext.Products.AddAsync(product);

            if (result.State == EntityState.Added)
            {
                var numberOfEffectedRows = await _dbContext.SaveChangesAsync();

                return numberOfEffectedRows;
            }
            return 0;
         
        }
    }
}
