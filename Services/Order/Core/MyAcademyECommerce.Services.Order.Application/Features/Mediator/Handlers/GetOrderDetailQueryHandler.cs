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
    public class GetOrderDetailQueryHandler : IRequestHandler<GetOrderDetailQuery, List<GetOrderDetailQueryResult>>
    {

        private readonly IRepository<OrderDetail> _orderDetailRepository;
        private readonly IMapper _mapper;

        public GetOrderDetailQueryHandler(IRepository<OrderDetail> orderDetailRepository, IMapper mapper)
        {
            _orderDetailRepository = orderDetailRepository;
            _mapper = mapper;
        }

        public async Task<List<GetOrderDetailQueryResult>> Handle(GetOrderDetailQuery request, CancellationToken cancellationToken)
        {
            var values = await _orderDetailRepository.GetAllAsync();
            return _mapper.Map<List<GetOrderDetailQueryResult>>(values);
        }
    }
}
