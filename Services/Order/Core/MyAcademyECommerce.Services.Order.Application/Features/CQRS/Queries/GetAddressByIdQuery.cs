using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyECommerce.Services.Order.Application.Features.CQRS.Queries
{
    public class GetAddressByIdQuery
    {
        public int AddressId { get; set; }

        public GetAddressByIdQuery(int id)
        {
            AddressId = id;
        }
    }
}
