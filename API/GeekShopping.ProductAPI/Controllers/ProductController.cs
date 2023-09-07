using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
