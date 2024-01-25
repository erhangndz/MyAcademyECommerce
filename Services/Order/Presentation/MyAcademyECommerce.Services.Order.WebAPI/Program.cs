using MediatR;
using Microsoft.EntityFrameworkCore;
using MyAcademyECommerce.Services.Order.Application.Features.CQRS.Handlers;
using MyAcademyECommerce.Services.Order.Application.Features.Mediator.Commands;
using MyAcademyECommerce.Services.Order.Application.Features.Mediator.Handlers;
using MyAcademyECommerce.Services.Order.Application.Features.Mediator.Queries;
using MyAcademyECommerce.Services.Order.Application.Features.Mediator.Results;
using MyAcademyECommerce.Services.Order.Application.Interfaces;
using MyAcademyECommerce.Services.Order.Persistance.Context;
using MyAcademyECommerce.Services.Order.Persistance.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped(typeof(IRepository<>),typeof(GenericRepository<>));
builder.Services.AddScoped<CreateAddressCommandHandler>();
builder.Services.AddScoped<UpdateAddressCommandHandler>();
builder.Services.AddScoped<GetAddressQueryHandler>();
builder.Services.AddScoped<GetAddressByIdQueryHandler>();
builder.Services.AddScoped<RemoveAddressCommandHandler>();
builder.Services.AddScoped<CreateOrderingCommandHandler>();
builder.Services.AddScoped<GetOrderingQueryHandler>();
builder.Services.AddDbContext<OrderContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
   
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
