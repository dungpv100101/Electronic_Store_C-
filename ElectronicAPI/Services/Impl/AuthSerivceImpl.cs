using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using DataAccess.Models;
using BusinessObject.DTO.Response;

namespace ElectronicAPI.Services.Impl
{
    public class AuthSerivceImpl : IAuthService
    {
        private readonly Electronic_Shop_SystemContext _context;
        private readonly IMapper _mapper;

        public AuthSerivceImpl(Electronic_Shop_SystemContext _context, IMapper _mapper)
        {
            this._context = _context;
            this._mapper = _mapper;
        }


        public BaseResponse authenticate(string account, string password, HttpContext context)
        {

            // check user valid 
            User user = _context.Users.Where(user => user.Account.Equals(account) && user.Password.Equals(password)).FirstOrDefault();
            if (user != null)
            {
                var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, user.Name),
                            new Claim(ClaimTypes.Email, user.Account),
                            new Claim(ClaimTypes.MobilePhone, user.Phone),
                            new Claim(ClaimTypes.MobilePhone, user.Phone),
                            new Claim(ClaimTypes.Role, user.IsStaff == 1 ? "staff" : user.IsManager == 1 ? "manager" : "user"),
                        };
                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties { };
                context.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                return BaseResponse.Success(user);

            }
            else
            {
                return BaseResponse.Error();
            }
        }

        public BaseResponse logout(HttpContext context)
        {
            context.SignOutAsync(
                 CookieAuthenticationDefaults.AuthenticationScheme);

            return BaseResponse.Success();
        }
    }
}
