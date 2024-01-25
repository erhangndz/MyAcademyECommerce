using AutoMapper;
using MyAcademyECommerce.Services.Order.Application.Features.CQRS.Commands;
using MyAcademyECommerce.Services.Order.Application.Interfaces;
using MyAcademyECommerce.Services.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyECommerce.Services.Order.Application.Features.CQRS.Handlers
{
    public class CreateAddressCommandHandler
    {

        private readonly IRepository<Address> _repository;
        private readonly IMapper _mapper;

        public CreateAddressCommandHandler(IRepository<Address> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateAddressCommand command)
        {
            var address = _mapper.Map<Address>(command);
            await _repository.CreateAsync(address);
        }
    }
}
