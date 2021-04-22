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
            CreateMap<Country, CountryResource>();
            CreateMap<Region, RegionResource>();
            CreateMap<District, DistrictResource>();

            //Resource To Domain
            CreateMap<ApplicationUserResource, Data.Models.Auth.ApplicationUser>();
            CreateMap<SaveApplicationUserResource, Data.Models.Auth.ApplicationUser>();
            CreateMap<CountryResource, Country>();
            CreateMap<SaveCountryResource, Country>();
            CreateMap<RegionResource, Region>();
            CreateMap<SaveRegionResource, Region>();
            CreateMap<DistrictResource, District >();
            CreateMap<SaveDistrictResource, District>();

            //CreateMap<UserSignUpResource, User>()
            //    .ForMember(u => u.UserName, opt => opt.MapFrom(ur => ur.Email));
        }
    }
}
