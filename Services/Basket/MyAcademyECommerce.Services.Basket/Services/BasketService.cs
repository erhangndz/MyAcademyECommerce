using MyAcademyECommerce.Services.Basket.Dtos;

namespace MyAcademyECommerce.Services.Basket.Services
{
    public class BasketService : IBasketService
    {

        private readonly RedisService _redisService;

        public BasketService(RedisService redisService)
        {
            _redisService = redisService;
        }

        public Task DeleteBasketAsync(string UserId)
        {
            throw new NotImplementedException();
        }

        public Task<BasketTotalDto> GetBasketTotalAsync(string UserId)
        {
            throw new NotImplementedException();
        }

        public Task SaveBasketAsync(BasketTotalDto basketTotalDto)
        {
            throw new NotImplementedException();
        }
    }
}
