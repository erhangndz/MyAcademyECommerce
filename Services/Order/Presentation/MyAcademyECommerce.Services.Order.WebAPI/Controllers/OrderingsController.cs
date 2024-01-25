using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using MyAcademyECommerce.Services.Order.Application.Features.Mediator.Commands;
using MyAcademyECommerce.Services.Order.Application.Features.Mediator.Queries;

namespace MyAcademyECommerce.Services.Order.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderingsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetOrderings()
        {
            
            var values = await _mediator.Send(new GetOrderingQuery());
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrdering(CreateOrderingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Sipariş Oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrdering(UpdateOrderingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Sipariş Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrdering(int id)
        {
            await _mediator.Send(new RemoveOrderingCommand(id));
            return Ok("Sipariş Silindi");
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderingById(int id)
        {
           var value=  await _mediator.Send(new GetOrderingByIdQuery(id));
            return Ok(value);
        }
    }
}
