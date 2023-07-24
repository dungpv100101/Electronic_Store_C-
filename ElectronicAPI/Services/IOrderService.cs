using BusinessObject.DTO.Response;

namespace ElectronicAPI.Services
{
    public interface IOrderService
    {
        BaseResponse List(int? userId, string? username);
        BaseResponse Delivered(int orderId);
    }
}
