using ElectronicAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicAPI.Controllers
{
    [ApiController]
    [Route("v1/api/[controller]/[action]")]
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IActionResult List(int pageNumber = 1, int pageSize = 3, string? productName = "", int categoryID = 0)
        {
            return Ok(productService.List(pageNumber, pageSize, productName, categoryID));
        }
    }
}
