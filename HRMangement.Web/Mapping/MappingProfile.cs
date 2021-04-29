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
            CreateMap<Disability, DisabilityResource>();
            CreateMap<Language, LanguageResource>();
            CreateMap<MilitaryServiceStatus, MilitaryServiceStatusResource>();
            CreateMap<MilitaryTitle, MilitaryTitleResource>();
            CreateMap<Nationality, NationalityResource>();
            CreateMap<Partisanship, PartisanshipResource>();
            CreateMap<PositionDegree, PositionDegreeResource>();
            CreateMap<Relative, RelativeResource>();
            CreateMap<RelativeWorkingStatus, RelativeWorkingStatusResource>();
            CreateMap<ScienceDegree, ScienceDegreeResource>();
            CreateMap<VacationType, VacationTypeResource>();
            CreateMap<DisciplinaryActionType, DisciplinaryActionTypeResource>();
            CreateMap<EdInformation, EdInformationResource>();
            CreateMap<EdInformation, EdInformationResource>();
            CreateMap<Passport, PassportResource>();
            CreateMap<Education, EducationResource>();


            //Resource To Domain
            CreateMap<ApplicationUserResource, Data.Models.Auth.ApplicationUser>();
            CreateMap<SaveApplicationUserResource, Data.Models.Auth.ApplicationUser>();
            CreateMap<CountryResource, Country>();
            CreateMap<SaveCountryResource, Country>();
            CreateMap<RegionResource, Region>();
            CreateMap<SaveRegionResource, Region>();
            CreateMap<DistrictResource, District >();
            CreateMap<SaveDistrictResource, District>();
            CreateMap<DisabilityResource, Disability>();
            CreateMap<SaveDisabilityResource, Disability>();
            CreateMap<LanguageResource, Language>();
            CreateMap<SaveLanguageResource, Language>();
            CreateMap<MilitaryServiceStatusResource, MilitaryServiceStatus>();
            CreateMap<SaveMilitaryServiceResource, MilitaryServiceStatus>();
            CreateMap<MilitaryTitleResource, MilitaryTitle>();
            CreateMap<SaveMilitaryTitleResource, MilitaryTitle>();
            CreateMap<NationalityResource, Nationality>();
            CreateMap<SaveNationalityResource, Nationality>();
            CreateMap<PartisanshipResource, Partisanship>();
            CreateMap<SavePartisanshipResource, Partisanship>();
            CreateMap<PositionDegreeResource, PositionDegree>();
            CreateMap<SavePositionDegree, PositionDegree>();
            CreateMap<RelativeResource, Relative>();
            CreateMap<SaveRelativeResource, Relative>();
            CreateMap<RelativeWorkingStatusResource, RelativeWorkingStatus>();
            CreateMap<SaveRelativeWorkingStatusResource, RelativeWorkingStatus>();
            CreateMap<ScienceDegreeResource, ScienceDegree>();
            CreateMap<SaveScienceDegreeResource, ScienceDegree>();
            CreateMap<VacationTypeResource, VacationType>();
            CreateMap<SaveVacationTypeResource, VacationType>();
            CreateMap<DisciplinaryActionTypeResource, DisciplinaryActionType>();
            CreateMap<SaveDisciplinaryActionTypeResource, DisciplinaryActionType>();
            CreateMap<EdInformationResource, EdInformation>();
            CreateMap<SaveEdInformationResource, EdInformation>();
            CreateMap<PassportResource, Passport>();
            CreateMap<SavePassportResource, Passport>();
            CreateMap<EducationResource, Education>();
            CreateMap<SaveEducationResource, Education>();

            //CreateMap<UserSignUpResource, User>()
            //    .ForMember(u => u.UserName, opt => opt.MapFrom(ur => ur.Email));
        }
    }
}
