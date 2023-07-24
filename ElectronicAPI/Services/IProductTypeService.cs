using BusinessObject.DTO.Response;
using DataAccess.Models;

namespace ElectronicAPI.Services
{
    public interface IProductTypeService
    {
        BaseResponse List();
        BaseResponse Add(ProductType productType);
    }
}
