using ElectronicAPI.Services;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicAPI.Controllers
{
    [ApiController]
    [Route("v1/api/[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult List(string? username)
        {
            return Ok(userService.List(username));
        }

        [HttpPost]
        public IActionResult SetStaff(int userId, int isStaff)
        {
            return Ok(userService.SetStaff(userId, isStaff));
        }


        [HttpPost]
        public IActionResult Add(User user)
        {
            return Ok(userService.Add(user));
        }
    }
}
