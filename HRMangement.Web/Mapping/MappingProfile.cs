using HRManagement.Models;
using HRManagement.Web.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace HRManagement.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain To Resource
            CreateMap<Data.Models.Auth.ApplicationUser, ApplicationUserResource>();

            //Resource To Domain
            CreateMap<ApplicationUserResource, Data.Models.Auth.ApplicationUser>();
            CreateMap<SaveApplicationUserResource, Data.Models.Auth.ApplicationUser>();
            
            //CreateMap<UserSignUpResource, User>()
            //    .ForMember(u => u.UserName, opt => opt.MapFrom(ur => ur.Email));
        }
    }
}
