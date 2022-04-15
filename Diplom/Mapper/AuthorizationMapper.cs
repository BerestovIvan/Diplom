using AutoMapper;
using BLL.Models;
using DAL.Entity;
using DAL.Models;
using System;
using WebForumMVC.Models.AuthenticationModels;

namespace Diplom.Mapper
{
    public class AuthorizationMapper : Profile
    {
        public AuthorizationMapper()
        {
            CreateMap<RegisterPostModel, RegisterModel>().ReverseMap();
            CreateMap<LoginModel, LoginPostModel>().ReverseMap();
            CreateMap<LoginResultModel, LoginResultPostModel>().ReverseMap();

            CreateMap<ApplicationUser, RegisterModel>().ReverseMap().
              ForMember(applicationUser => applicationUser.SecurityStamp,
              registerModel => Guid.NewGuid().ToString());

            CreateMap<ApplicationUser, LoginModel>().ReverseMap();
               
            CreateMap<UserModel, ApplicationUser>().ReverseMap();
            CreateMap<LoginResultModel, LoginResult>().ReverseMap();
        }

    }
}
