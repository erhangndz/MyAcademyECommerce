using MediatR;
using MyAcademyECommerce.Services.Order.Application.Features.Mediator.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyECommerce.Services.Order.Application.Features.Mediator.Queries
{
    public class GetOrderingByIdQuery:IRequest<GetOrderingByIdQueryResult>
    {

        public int OrderingId { get; set; }

        public GetOrderingByIdQuery(int id)
        {
            OrderingId = id;
        }
    }
}
