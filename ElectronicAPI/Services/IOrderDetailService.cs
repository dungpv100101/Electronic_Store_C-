using BusinessObject.DTO.Response;

namespace ElectronicAPI.Services
{
    public interface IOrderDetailService
    {
        BaseResponse List(int? orderId);
    }
}
