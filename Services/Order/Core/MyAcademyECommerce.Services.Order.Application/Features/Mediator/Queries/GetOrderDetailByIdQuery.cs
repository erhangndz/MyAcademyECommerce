using MediatR;
using MyAcademyECommerce.Services.Order.Application.Features.Mediator.Results;
using MyAcademyECommerce.Services.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyECommerce.Services.Order.Application.Features.Mediator.Queries
{
    public class GetOrderDetailByIdQuery: IRequest<GetOrderDetailByIdQueryResult>
    {
        public int OrderDetailId { get; set; }

        public GetOrderDetailByIdQuery(int id)
        {
            OrderDetailId = id;
        }
    }
}
