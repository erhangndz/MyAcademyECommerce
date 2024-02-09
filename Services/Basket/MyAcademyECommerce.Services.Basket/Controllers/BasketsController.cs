using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAcademyECommerce.Services.Basket.LoginServices;
using MyAcademyECommerce.Services.Basket.Services;

namespace MyAcademyECommerce.Services.Basket.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly IBasketService _basketService;

        public BasketsController(ILoginService loginService, IBasketService basketService)
        {
            _loginService = loginService;
            _basketService = basketService;
        }

        [HttpGet]
       public async Task<IActionResult> GetBasket()
        {
            var basket = await _basketService.GetBasketTotalAsync(_loginService.GetUserId);

            if (basket == null)
            {
                return NotFound();
            }
            return Ok(basket);
        }



    }
}
