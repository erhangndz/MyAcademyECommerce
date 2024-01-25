using AutoMapper;
using MyAcademyECommerce.Services.Order.Application.Features.CQRS.Queries;
using MyAcademyECommerce.Services.Order.Application.Features.CQRS.Results;
using MyAcademyECommerce.Services.Order.Application.Interfaces;
using MyAcademyECommerce.Services.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyECommerce.Services.Order.Application.Features.CQRS.Handlers
{
    public class GetAddressByIdQueryHandler
    {

        private readonly IRepository<Address> _repository;
        private readonly IMapper _mapper;

        public GetAddressByIdQueryHandler(IRepository<Address> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAddressByIdQueryResult> Handle(int id)
        {
            var query = new GetAddressByIdQuery(id);
            var value = await _repository.GetByIdAsync(query.AddressId);
           return _mapper.Map<GetAddressByIdQueryResult>(value);
        }
    }
}
