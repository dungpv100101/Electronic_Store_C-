using ElectronicAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicAPI.Controllers
{
    [ApiController]
    [Route("v1/api/[controller]/[action]")]
    public class ProductTypeController : Controller
    {
        private readonly IProductTypeService productTypeService;
        public ProductTypeController(IProductTypeService productTypeService)
        {
            this.productTypeService = productTypeService;
        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok(productTypeService.List());
        }
    }
}
