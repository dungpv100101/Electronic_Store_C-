using BusinessObject.DTO;
using ElectronicAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicAPI.Controllers
{
    [ApiController]
    [Route("v1/api/[controller]/[action]")]
    public class AuthController : Controller
    {
        private readonly IAuthService authService;
        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(LoginDTO request)
        {
            return Ok(authService.authenticate(request.username, request.password, HttpContext));
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Logout()
        {
            return Ok(authService.logout(HttpContext));
        }
    }
}
