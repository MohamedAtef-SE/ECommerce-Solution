using Ecommerce.BL.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.PL.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // {{BaseURL}}/api/Proudct
    public class ProudctController : ControllerBase
    {
        [HttpGet] // {{BaseURL}}/api/Product/
        public ActionResult<IEnumerable<ProductDTO>> GetAllProducts()
        {

        }
    }
}
