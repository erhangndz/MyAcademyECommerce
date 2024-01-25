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
    public class RemoveAddressCommandHandler
    {
        private readonly IRepository<Address> _addressRepository;
        private readonly IMapper _mapper;

        public RemoveAddressCommandHandler(IRepository<Address> addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task Handle(int id)
        {
            var query = new RemoveAddressCommand(id);
            await _addressRepository.DeleteAsync(query.AddressId);
        }
    }
}
