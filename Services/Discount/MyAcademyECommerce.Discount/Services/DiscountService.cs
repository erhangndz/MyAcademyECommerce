using AutoMapper;
using Dapper;
using MyAcademyECommerce.Discount.Context;
using MyAcademyECommerce.Discount.Dtos;

namespace MyAcademyECommerce.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DiscountContext _context;
        

        public DiscountService(DiscountContext context)
        {
            _context = context;
        
        }

        public async Task CreateCouponAsync(CreateCouponDto createCouponDto)
        {
            string query = "insert into Coupons (Code,Rate,IsActive,ValidDate) values (@code,@rate,@isActive,@validDate)";
            var parameters = new DynamicParameters();
            parameters.Add("@code", createCouponDto.Code);
            parameters.Add("@rate", createCouponDto.Rate);
            parameters.Add("isActive", true);
            parameters.Add("@validDate", DateTime.Now.AddDays(10));
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }

        }

        public async Task DeleteCouponAsync(int id)
        {
            string query = $"delete from Coupons where CouponId='{id}'";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query);
        }

        public async Task<List<ResultCouponDto>> GetAllCouponsAsync()
        {
            string query = "select * from Coupons";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultCouponDto>(query);
            return values.ToList();
        }

        public async Task<ResultCouponDto> GetCouponByIdAsync(int id)
        {
            string query = $" select * from Coupons where CouponId={id}";
            using var connection = _context.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<ResultCouponDto>(query);

        }

        public async Task UpdateCouponAsync(UpdateCouponDto updateCouponDto)
        {
            string query = $"update coupons set code=@code,rate=@rate,IsActive=@IsActive,validDate=@validDate where couponId=@Id";
            var parameters = new DynamicParameters();
            parameters.Add("@code", updateCouponDto.Code);
            parameters.Add("@rate", updateCouponDto.Rate);
            parameters.Add("IsActive", updateCouponDto.IsActive);
            parameters.Add("@validDate", updateCouponDto.ValidDate);
            parameters.Add("@Id", updateCouponDto.CouponId);

            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query,parameters);
        }
    }
}
