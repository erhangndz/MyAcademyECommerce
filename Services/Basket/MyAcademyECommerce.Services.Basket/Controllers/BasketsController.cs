using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAcademyECommerce.Services.Basket.LoginServices;

namespace MyAcademyECommerce.Services.Basket.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public BasketsController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpGet]
        public  IActionResult GetUserInfo()
        {
            var user = _loginService.GetUserId;
            return Ok("Kullanıcı bilgisi alındı");
        } 
    }
}
