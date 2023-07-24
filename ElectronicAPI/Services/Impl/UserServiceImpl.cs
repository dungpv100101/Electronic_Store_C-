using AutoMapper;
using BusinessObject.DTO.Response;
using Eletronic.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectronicAPI.Services.Impl
{
    public class UserServiceImpl : IUserService
    {
        private readonly Electronic_Shop_SystemContext _context;
        private readonly IMapper _mapper;

        public UserServiceImpl(Electronic_Shop_SystemContext _context, IMapper _mapper)
        {
            this._context = _context;
            this._mapper = _mapper;
        }
        public BaseResponse Add(User user)
        {
            _context.Users.Add(user);

            if (_context.SaveChanges() > 0) return BaseResponse.Success();

            return BaseResponse.Error();
        }

        public BaseResponse List(string? name)
        {
            return BaseResponse.Success(_context.Users.Where(o =>
                (name == null || (name != null && o.Name.Equals(name)))
            ));
        }

        public BaseResponse SetStaff(int userId, int isStaff)
        {
            try
            {
                _context.Users.Find(userId).IsStaff = isStaff;

                return BaseResponse.Success(_context.SaveChanges());
            } catch (Exception ex)
            {
                return BaseResponse.Error(ex.Message);
            }
        }
    }
}
