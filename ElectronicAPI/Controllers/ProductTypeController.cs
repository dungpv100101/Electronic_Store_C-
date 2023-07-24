using ElectronicAPI.Services;
using Eletronic.Models;
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

        [HttpPost]
        public IActionResult Add(ProductType productType)
        {
            return Ok(productTypeService.Add(productType));
        }
    }
}
