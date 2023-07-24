using BusinessObject.DTO.Response;
using Eletronic.Models;

namespace ElectronicAPI.Services
{
    public interface IOrderDetailService
    {
        BaseResponse List(int? orderId);
        BaseResponse Add(OrderDetail orderDetail);
    }
}
