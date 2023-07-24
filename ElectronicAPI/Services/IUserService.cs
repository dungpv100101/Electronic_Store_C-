using BusinessObject.DTO.Response;
using DataAccess.Models;

namespace ElectronicAPI.Services
{
    public interface IUserService
    {
        BaseResponse Add(User user);
        BaseResponse List(string? name);
        BaseResponse SetStaff(int userId, int isStaff);
    }
}
