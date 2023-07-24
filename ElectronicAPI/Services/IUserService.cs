using BusinessObject.DTO.Response;
using Eletronic.Models;

namespace ElectronicAPI.Services
{
    public interface IUserService
    {
        BaseResponse Add(User user);
        BaseResponse List(string? name);
        BaseResponse SetStaff(int userId, int isStaff);
    }
}
