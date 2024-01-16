using AutoMapper;
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
    public class GetAddressQueryHandler
    {
        private readonly IRepository<Address> _repository;
        private readonly IMapper _mapper;

        public GetAddressQueryHandler(IRepository<Address> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetAddressQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            var result =_mapper.Map<List<GetAddressQueryResult>>(values);
            return result;
        }
    }
}
