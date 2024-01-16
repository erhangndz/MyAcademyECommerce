using AutoMapper;
using MyAcademyECommerce.Services.Order.Application.Features.CQRS.Results;
using MyAcademyECommerce.Services.Order.Domain.Entities;

namespace MyAcademyECommerce.Services.Order.WebAPI.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<GetAddressQueryResult, Address>().ReverseMap();
            CreateMap<GetAddressByIdQueryResult, Address>().ReverseMap();
        }
    }
}
