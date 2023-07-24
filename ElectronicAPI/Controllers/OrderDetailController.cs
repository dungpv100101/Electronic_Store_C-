using ElectronicAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicAPI.Controllers
{
    [ApiController]
    [Route("v1/api/[controller]/[action]")]
    public class OrderDetailController : Controller
    {
        private readonly IOrderDetailService orderDetailService;
        public OrderDetailController(IOrderDetailService orderDetailService)
        {
            this.orderDetailService = orderDetailService;
        }

        [HttpGet]
        public IActionResult List(int? orderId)
        {
            return Ok(orderDetailService.List(orderId));
        }
    }
}
