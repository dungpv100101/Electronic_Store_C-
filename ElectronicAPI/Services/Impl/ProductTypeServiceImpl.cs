using AutoMapper;
using BusinessObject.DTO.Response;
using Eletronic.Models;

namespace ElectronicAPI.Services.Impl
{
    public class ProductTypeServiceImpl : IProductTypeService
    {
        private readonly Electronic_Shop_SystemContext _context;
        private readonly IMapper _mapper;

        public ProductTypeServiceImpl(Electronic_Shop_SystemContext _context, IMapper _mapper)
        {
            this._context = _context;
            this._mapper = _mapper;
        }
        public BaseResponse List()
        {
            return BaseResponse.Success(_context.ProductTypes.ToList());
        }
    }
}
