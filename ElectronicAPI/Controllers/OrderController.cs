using ElectronicAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicAPI.Controllers
{
    [ApiController]
    [Route("v1/api/[controller]/[action]")]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet]
        public IActionResult List(int? userId, string? username)
        {
            return Ok(orderService.List(userId, username));
        }

        [HttpPost]
        public IActionResult Delevired(int orderId) 
        {
            return Ok(orderService.Delivered(orderId));
        }
    }
}
