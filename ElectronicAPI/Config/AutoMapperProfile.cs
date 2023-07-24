using AutoMapper;
using BusinessObject.DTO;
using BusinessObject.DTO.Request;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Config
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Product, ProductDTO>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
        }
    }
}
