using Microsoft.EntityFrameworkCore;
using MyAcademyECommerce.Services.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyECommerce.Services.Order.Persistance.Context
{
    public class OrderContext:DbContext
    {
        public OrderContext(DbContextOptions options) :base(options) { }
       


        public DbSet<Address> Addresses { get; set; }
        public DbSet<Ordering> Orderings { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
