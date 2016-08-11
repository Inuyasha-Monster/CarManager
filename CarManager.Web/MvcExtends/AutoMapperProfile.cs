using AutoMapper;
using CarManager.Data.Model;
using CarManager.Web.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarManager.Web.MvcExtends
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<Car, CarViewModel>().ForMember(d => d.Email, opt => opt.UseValue<string>("972417907@qq.com"));
            this.CreateMap<CarViewModel, Car>();
        }
    }
}