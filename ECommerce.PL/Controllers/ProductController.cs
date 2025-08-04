using Ecommerce.BL.DTOs;
using Ecommerce.BL.Interfaces;
using Ecommerce.BL.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.PL.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // {{BaseURL}}/api/Proudct
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet] // {{BaseURL}}/api/Product/
        public ActionResult<IEnumerable<ProductDTO>> GetAllProducts()
        {
            var result = _productService.GetAllProducts();

            if (result is null) return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> AddProuduct(ProductDTO productDTO)
        {
           var result = await _productService.AddProduct(productDTO);
            if (result == true)
            {
                return Ok();
            }
            return BadRequest("can not add new product");
        }
    }
}
