using AutoMapper;
using BusinessObject.DTO.Response;
using Eletronic.Models;

namespace ElectronicAPI.Services.Impl
{
    public class ProductServiceImpl : IProductService
    {
        private readonly Electronic_Shop_SystemContext _context;
        private readonly IMapper _mapper;

        public ProductServiceImpl(Electronic_Shop_SystemContext _context, IMapper _mapper)
        {
            this._context = _context;
            this._mapper = _mapper;
        }
        public BaseResponse List(int pageNumber = 1, int pageSize = 3, string productName = "", int categoryID = 0)
        {
            List<Product> listProduct = _context.Products.Where(p => p.Name.Contains(productName == null ? "" : productName) && p.ProductTypeId == (categoryID == 0 ? p.ProductTypeId : categoryID)).ToList();

            return BaseResponse.Success(listProduct);
        }
        
        public BaseResponse Add(Product product)
        {
            _context.Products.Add(product);
            
            return BaseResponse.Success(_context.SaveChanges());
        }
    }
}
