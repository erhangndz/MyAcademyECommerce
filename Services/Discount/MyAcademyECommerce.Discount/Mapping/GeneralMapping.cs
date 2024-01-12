using AutoMapper;
using MyAcademyECommerce.Discount.Dtos;
using MyAcademyECommerce.Discount.Models;

namespace MyAcademyECommerce.Discount.Mapping
{
    public class GeneralMapping: Profile
    {

        public GeneralMapping()
        {
            CreateMap<Coupon, CreateCouponDto>().ReverseMap();
            CreateMap<Coupon, UpdateCouponDto>().ReverseMap();
            CreateMap<Coupon, ResultCouponDto>().ReverseMap();
        }
    }
}
