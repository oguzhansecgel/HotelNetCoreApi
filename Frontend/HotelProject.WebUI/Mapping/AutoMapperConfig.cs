﻿using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutUsDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();


            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();


            CreateMap<LoginUserDto,AppUser>().ReverseMap();


            CreateMap<ResultAboutUsDto,AboutUs>().ReverseMap();
            CreateMap<UpdateAboutUsDto,AboutUs>().ReverseMap();

            CreateMap<ResultStaffDto,Staff>().ReverseMap();

        }
    }
}
