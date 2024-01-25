using AutoMapper;
using MediatR;
using MyAcademyECommerce.Services.Order.Application.Features.Mediator.Queries;
using MyAcademyECommerce.Services.Order.Application.Features.Mediator.Results;
using MyAcademyECommerce.Services.Order.Application.Interfaces;
using MyAcademyECommerce.Services.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyECommerce.Services.Order.Application.Features.Mediator.Handlers
{
    public class GetOrderingQueryHandler : IRequestHandler<GetOrderingQuery, List<GetOrderingQueryResult>>
    {

        private readonly IRepository<Ordering> _repository;
        private readonly IMapper _mapper;

        public GetOrderingQueryHandler(IRepository<Ordering> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public  async Task<List<GetOrderingQueryResult>> Handle(GetOrderingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return _mapper.Map<List<GetOrderingQueryResult>>(values);
        }
    }
}
