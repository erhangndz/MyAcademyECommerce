using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyECommerce.Services.Order.Application.Features.CQRS.Commands
{
    public class RemoveAddressCommand
    {
        public int AddressId { get; set; }

        public RemoveAddressCommand(int id)
        {
            AddressId = id;
        }
    }
}
