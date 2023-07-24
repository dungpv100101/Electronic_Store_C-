using BusinessObject.DTO.Response;

namespace ElectronicAPI.Services
{
    public interface IAuthService
    {
        BaseResponse authenticate(string account, string password, HttpContext context);
        BaseResponse logout(HttpContext context);
    }
}
