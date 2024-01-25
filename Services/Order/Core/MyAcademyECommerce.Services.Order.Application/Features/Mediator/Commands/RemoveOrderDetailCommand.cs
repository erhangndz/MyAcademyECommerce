using MediatR;
using MyAcademyECommerce.Services.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyECommerce.Services.Order.Application.Features.Mediator.Commands
{
    public class RemoveOrderDetailCommand:IRequest
    {
        public int OrderDetailId { get; set; }

        public RemoveOrderDetailCommand(int id)
        {
            OrderDetailId = id;
        }
    }
}
