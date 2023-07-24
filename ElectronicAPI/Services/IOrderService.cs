using BusinessObject.DTO.Response;
using DataAccess.Models;

namespace ElectronicAPI.Services
{
    public interface IOrderService
    {
        BaseResponse List(int? userId, string? username);
        BaseResponse Delivered(int orderId);

        BaseResponse Add(Order order);
    }
}
