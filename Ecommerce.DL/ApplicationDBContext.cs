using ECommerce.DL.Entites;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.DL
{
    public class ApplicationDBContext 
    {
        public DbSet<Product> Products { get; set; }
    }
}
