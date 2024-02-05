using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyAcademyECommerce.IdentityServer.Dtos;
using MyAcademyECommerce.IdentityServer.Models;
using System.Threading.Tasks;

namespace MyAcademyECommerce.IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RegistersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserRegisterDto userRegisterDto)
        {
            var user = new ApplicationUser()
            {
                City = userRegisterDto.City,
                Email = userRegisterDto.Email,
                NameSurname = userRegisterDto.NameSurname,
                UserName = userRegisterDto.UserName

            };
           
           var result = await _userManager.CreateAsync(user,userRegisterDto.Password);
            if(!result.Succeeded)
            {
                return Ok("Kullanıcı Kayıt Edilirken Bir Hata Oluştu");
            }
            return Ok("Kullanıcı Kayıt Edildi");
        }
    }
}
