using AutoMapper;
using BusinessObject.DTO.Response;
using Eletronic.Models;

namespace ElectronicAPI.Services.Impl
{
    public class OrderServiceImpl : IOrderService
    {
        private readonly Electronic_Shop_SystemContext _context;
        private readonly IMapper _mapper;

        public OrderServiceImpl(Electronic_Shop_SystemContext _context, IMapper _mapper)
        {
            this._context = _context;
            this._mapper = _mapper;
        }
        public BaseResponse List(int? userId, string? username)
        {
            return BaseResponse.Success(_context.Orders.Where(o =>
                (userId == null || (userId != null && o.StaffId == userId))
                && (username == null || (username != null && o.Name == username))
            ));
        }

        public BaseResponse Delivered(int orderId)
        {
            ((Order)_context.Orders.Find(orderId)).DeliverDate = DateTime.Now;
            
            return BaseResponse.Success(_context.SaveChanges());
        }
    }
}
