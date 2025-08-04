using AutoMapper;
using Ecommerce.BL.DTOs;
using ECommerce.DL.Entites;

namespace Ecommerce.BL.Mapping
{
    public class MappingProfile : Profile
    {
        
        public MappingProfile()
        {
           CreateMap<Product,ProductDTO>().ReverseMap();
        }
    }
}
