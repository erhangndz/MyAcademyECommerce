using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MyAcademyECommerce.Discount.Models;
using System.Data;

namespace MyAcademyECommerce.Discount.Context
{
    public class DiscountContext : DbContext
    {

        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DiscountContext(IConfiguration configuration,DbContextOptions options): base(options)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public DbSet<Coupon> Coupons { get; set; }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
