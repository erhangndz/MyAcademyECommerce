using MyAcademyECommerce.Services.Basket.Dtos;

namespace MyAcademyECommerce.Services.Basket.Services
{
    public interface IBasketService
    {
        Task<BasketTotalDto> GetBasketTotalAsync(string UserId);

        Task SaveBasketAsync(BasketTotalDto basketTotalDto);

        Task DeleteBasketAsync(string UserId);

    }
}
