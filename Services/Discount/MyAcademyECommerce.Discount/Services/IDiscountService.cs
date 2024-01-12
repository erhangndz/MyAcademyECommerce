using MyAcademyECommerce.Discount.Dtos;
using MyAcademyECommerce.Discount.Models;

namespace MyAcademyECommerce.Discount.Services
{
    public interface IDiscountService
    {
        Task<List<ResultCouponDto>> GetAllCouponsAsync();
        Task CreateCouponAsync(CreateCouponDto createCouponDto);

        Task DeleteCouponAsync(int id);

        Task UpdateCouponAsync(UpdateCouponDto updateCouponDto);

        Task<ResultCouponDto> GetCouponByIdAsync(int id);

       

    }
}
