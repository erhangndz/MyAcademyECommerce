using Microsoft.AspNetCore.Mvc;
using MyAcademyECommerce.Services.Basket.Dtos;
using MyAcademyECommerce.Services.Basket.LoginServices;
using Newtonsoft.Json;
using System.Net;

namespace MyAcademyECommerce.Services.Basket.Services
{
    public class BasketService : IBasketService
    {

        private readonly RedisService _redisService;
        private readonly ILoginService _loginService;

        public BasketService(RedisService redisService, ILoginService loginService)
        {
            _redisService = redisService;
            _loginService = loginService;
        }

        public async Task DeleteBasketAsync(string UserId)
        {
            await _redisService.GetDb().KeyDeleteAsync(UserId);
        }

        public async Task<BasketTotalDto> GetBasketTotalAsync(string UserId)
        {
           var basket = await _redisService.GetDb().StringGetAsync(UserId);
            if (String.IsNullOrEmpty(basket))
            {
                return new BasketTotalDto();
            }
           

            return JsonConvert.DeserializeObject<BasketTotalDto>(basket);
        }

        public async Task SaveBasketAsync(BasketTotalDto basketTotalDto)
        {
            var basket = JsonConvert.SerializeObject(basketTotalDto);
            await _redisService.GetDb().StringSetAsync(basketTotalDto.UserId,basket);
        }
    }
}
