using AutoMapper;
using MyAcademyECommerce.Services.Catalog.Dtos.CategoryDtos;
using MyAcademyECommerce.Services.Catalog.Dtos.ProductDtos;
using MyAcademyECommerce.Services.Catalog.Models;

namespace MyAcademyECommerce.Services.Catalog.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCategoryDto, Category>().ReverseMap();
            CreateMap<UpdateCategoryDto, Category>().ReverseMap();
            CreateMap<ResultCategoryDto, Category>().ReverseMap();


            CreateMap<ResultProductDto, Product>().ReverseMap();
            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();


        }
    }
}
