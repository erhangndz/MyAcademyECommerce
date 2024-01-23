using AutoMapper;
using MyAcademyECommerce.Services.Order.Application.Features.CQRS.Results;
using MyAcademyECommerce.Services.Order.Application.Features.Mediator.Commands;
using MyAcademyECommerce.Services.Order.Application.Features.Mediator.Results;
using MyAcademyECommerce.Services.Order.Domain.Entities;

namespace MyAcademyECommerce.Services.Order.WebAPI.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<GetAddressQueryResult, Address>().ReverseMap();
            CreateMap<GetAddressByIdQueryResult, Address>().ReverseMap();
            CreateMap<GetOrderingQueryResult, Ordering>().ReverseMap();
            CreateMap<CreateOrderingCommand, Ordering>().ReverseMap();
            CreateMap<RemoveOrderingCommand, Ordering>().ReverseMap();
            CreateMap<UpdateOrderingCommand, Ordering>().ReverseMap();
        }
    }
}
