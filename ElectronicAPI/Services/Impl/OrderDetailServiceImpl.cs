using AutoMapper;
using BusinessObject.DTO.Response;
using Eletronic.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectronicAPI.Services.Impl
{
    public class OrderDetailServiceImpl : IOrderDetailService
    {
        private readonly Electronic_Shop_SystemContext _context;
        private readonly IMapper _mapper;

        public OrderDetailServiceImpl(Electronic_Shop_SystemContext _context, IMapper _mapper)
        {
            this._context = _context;
            this._mapper = _mapper;
        }

        public BaseResponse Add(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);

            if (_context.SaveChanges() > 0) return BaseResponse.Success();

            return BaseResponse.Error();
        }

        public BaseResponse List(int? orderID)
        {
            List<OrderDetail> list = _context.OrderDetails.Include(s => s.Product).Where(s => s.OrderId == orderID).ToList();

            list.ForEach(o =>
            {
                o.Product.OrderDetails = null;
            });

            return BaseResponse.Success(list);
        }
    }
}
