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
            CreateMap<ApplicationUser, ApplicationUserResource>();

            //Resource To Domain
            CreateMap<ApplicationUserResource, ApplicationUser>();
            CreateMap<SaveApplicationUserResource, ApplicationUser>();
            
            //CreateMap<UserSignUpResource, User>()
            //    .ForMember(u => u.UserName, opt => opt.MapFrom(ur => ur.Email));
        }
    }
}
