using HRManagement.Data;
using HRManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Services.DataBook
{
    public class DataBookService : IDataBookService
    {
        private readonly HRManageDBContext _db;

        public DataBookService (HRManageDBContext db)
        {
            _db = db;
        }


        public async Task<Country> AddCountry(Country newCountry)
        {
            await _db.Countries.AddAsync(newCountry);
            await _db.SaveChangesAsync();
            return newCountry;
        }

        public async Task<DisciplinaryActionType> AddDAType(DisciplinaryActionType newDAtype)
        {
            await _db.DisciplinaryActionTypes.AddAsync(newDAtype);
            await _db.SaveChangesAsync();
            return newDAtype;
        }

        public async Task<DeputyMembership> AddDeputyMembership(DeputyMembership newDeputyMembership)
        {
            await _db.DeputyMemberships.AddAsync(newDeputyMembership);
            await _db.SaveChangesAsync();
            return newDeputyMembership;
        }

        public async Task<Disability> AddDisability(Disability newDisability)
        {
            await _db.Disabilities.AddAsync(newDisability);
            await _db.SaveChangesAsync();
            return newDisability;
        }

        public async Task<District> AddDistrict(District newDistrict)
        {
            await _db.Districts.AddAsync(newDistrict);
            await _db.SaveChangesAsync();
            return newDistrict;
        }

        public async Task<EdInformation> AddEdInfo(EdInformation newEdInfo)
        {
            await _db.EdInformations.AddAsync(newEdInfo);
            await _db.SaveChangesAsync();
            return newEdInfo;
        }

        public async Task<Language> AddLanguage(Language newLanguage)
        {
            await _db.Languages.AddAsync(newLanguage);
            await _db.SaveChangesAsync();
            return newLanguage;
        }

        public async Task<MilitaryTitle> AddMilitaryTitle(MilitaryTitle newMilitaryTitle)
        {
            await _db.MilitaryTitles.AddAsync(newMilitaryTitle);
            await _db.SaveChangesAsync();
            return newMilitaryTitle;
        }

        public async Task<MilitaryServiceStatus> AddMSStatus(MilitaryServiceStatus newMSStatus)
        {
            await _db.MilitaryServiceStatuses.AddAsync(newMSStatus);
            await _db.SaveChangesAsync();
            return newMSStatus;
        }

        public async Task<Nationality> AddNationality(Nationality newNationality)
        {
            await _db.Nationalities.AddAsync(newNationality);
            await _db.SaveChangesAsync();
            return newNationality;
        }

        public async Task<Partisanship> AddPartisanship(Partisanship newPartisanship)
        {
            await _db.Partisanships.AddAsync(newPartisanship);
            await _db.SaveChangesAsync();
            return newPartisanship;
        }

        public async Task<PositionDegree> AddPostionDegree(PositionDegree newPositionDegree)
        {
            await _db.PositionDegrees.AddAsync(newPositionDegree);
            await _db.SaveChangesAsync();
            return newPositionDegree;
        }

        public async Task<Region> AddRegion(Region newRegion)
        {
            await _db.Regions.AddAsync(newRegion);
            await _db.SaveChangesAsync();
            return newRegion;
        }

        public async Task<Relative> AddRelative(Relative newRelative)
        {
            await _db.Relatives.AddAsync(newRelative);
            await _db.SaveChangesAsync();
            return newRelative;
        }

        public async Task<RelativeWorkingStatus> AddRWStatus(RelativeWorkingStatus newRWStatus)
        {
            await _db.RelativeWorkingStatuses.AddAsync(newRWStatus);
            await _db.SaveChangesAsync();
            return newRWStatus;
        }

        public async Task<ScienceDegree> AddScienceDegree(ScienceDegree newScienceDegree)
        {
            await _db.ScienceDegrees.AddAsync(newScienceDegree);
            await _db.SaveChangesAsync();
            return newScienceDegree;
        }

        public async Task<VacationType> AddVacationType(VacationType newVacationType)
        {
            await _db.VacationTypes.AddAsync(newVacationType);
            await _db.SaveChangesAsync();
            return newVacationType;
        }

        public async Task DeleteCountry(int id)
        {
            var country = _db.Countries.Find(id);
            country.Status = false;
            await _db.SaveChangesAsync();
        }

        public async Task DeleteRegion(int id)
        {
            var region = _db.Regions.Find(id);
            region.Status = false;
            await _db.SaveChangesAsync();
        }

        public async Task DeleteDAType(int id)
        {
            var daType = _db.DisciplinaryActionTypes.Find(id);
            daType.Status = false;
            await _db.SaveChangesAsync();
        }

        public async Task DeleteDeputyMembership(int id)
        {
            var deputyMembership = _db.DeputyMemberships.Find(id);
            deputyMembership.Status = false;
            await _db.SaveChangesAsync();
        }

        public async Task DeleteDisability(int id)
        {
            var disability= _db.Disabilities.Find(id);
            disability.Status = false;
            await _db.SaveChangesAsync();
        }

        public async Task DeleteDistrict(int id)
        {
            var district = _db.Districts.Find(id);
            district.Status = false;
            await _db.SaveChangesAsync();
        }

        public async Task DeleteEdInfo(int id)
        {
            var edInfo = _db.EdInformations.Find(id);
            edInfo.Status = false;
            await _db.SaveChangesAsync();
        }

        public async Task DeleteLanguage(int id)
        {
            var language = _db.Languages.Find(id);
            language.Status = false;
            await _db.SaveChangesAsync();
        }

        public async Task DeleteMilitaryTitle(int id)
        {
            var militaryTitle = _db.MilitaryTitles.Find(id);
            militaryTitle.Status = false;
            await _db.SaveChangesAsync();
        }

        public async Task DeleteMSStatus(int id)
        {
            var msStatus = _db.MilitaryServiceStatuses.Find(id);
            msStatus.Status = false;
            await _db.SaveChangesAsync();
        }

        public async Task DeleteNationality(int id)
        {
            var nationality = _db.Nationalities.Find(id);
            nationality.Status = false;
            await _db.SaveChangesAsync();
        }

        public async Task DeletePartisanship(int id)
        {
            var partisanship = _db.Partisanships.Find(id);
            partisanship.Status = false;
            await _db.SaveChangesAsync();
        }

        public async Task DeletePositionDegree(int id)
        {
            var positionDegree = _db.PositionDegrees.Find(id);
            positionDegree.Status = false;
            await _db.SaveChangesAsync();
        }

        public async Task DeleteRelative(int id)
        {
            var relative = _db.Relatives.Find(id);
            relative.Status = false;
            await _db.SaveChangesAsync();
        }

        public async Task DeleteRWStatus(int id)
        {
            var rwStatus = _db.RelativeWorkingStatuses.Find(id);
            rwStatus.Status = false;
            await _db.SaveChangesAsync();
        }

        public async Task DeleteScienceDegree(int id)
        {
            var scienceDegree = _db.ScienceDegrees.Find(id);
            scienceDegree.Status = false;
            await _db.SaveChangesAsync(); 
        }

        public async Task DeleteVacationType(int id)
        {
            var vacationType = _db.VacationTypes.Find(id);
            vacationType.Status = false;
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Country>> GetAllCountries()
        {
            return await _db.Countries.Where(c => c.Status == true)
                 .OrderBy(c => c.CountryId)
                 .ToListAsync();
        }

        public async Task<IEnumerable<DisciplinaryActionType>> GetAllDATypes()
        {
            return await _db.DisciplinaryActionTypes
                 .Where(c => c.Status == true)
                 .OrderBy(c => c.DisciplinaryActionTypeId)
                 .ToListAsync();
        }

        public async Task<IEnumerable<DeputyMembership>> GetAllDeputyMemberships()
        {
            return await _db.DeputyMemberships
                .Where(c => c.Status == true)
                .OrderBy(c => c.DeputyMembershipId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Disability>> GetAllDisabilities()
        {
            return await _db.Disabilities
                .Where(c => c.Status == true)
                .OrderBy(c => c.DisabilityId)
                .ToListAsync();
        }

        public async Task<IEnumerable<District>> GetAllDistricts()
        {
            return await _db.Districts
                .Where(c => c.Status == true)
                .Include(d => d.Region)
                .ThenInclude(r => r.Country)
                .OrderBy(c => c.DisrictId)
                .ToListAsync();
        }

        public async Task<IEnumerable<EdInformation>> GetAllEdInfos()
        {
            return await _db.EdInformations
                .Where(c => c.Status == true)
                .OrderBy(c => c.EdInformationId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Language>> GetAllLanguages()
        {
            return await _db.Languages
                .Where(c => c.Status == true)
                .OrderBy(c => c.LanguageId)
                .ToListAsync();
        }

        public async Task<IEnumerable<MilitaryTitle>> GetAllMilitaryTitles()
        {
            return await _db.MilitaryTitles
                .Where(c => c.Status == true)
                .OrderBy(c => c.MilitaryTitleId)
                .ToListAsync();
        }

        public async Task<IEnumerable<MilitaryServiceStatus>> GetAllMSStatuses()
        {
            return await _db.MilitaryServiceStatuses
                .Where(c => c.Status == true)
                .OrderBy(c => c.MilitaryServiceStatusId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Nationality>> GetAllNationalities()
        {
            return await _db.Nationalities
                .Where(c => c.Status == true)
                .OrderBy(c => c.NationalityId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Partisanship>> GetAllPartisanships()
        {
            return await _db.Partisanships
                .Where(c => c.Status == true)
                .OrderBy(c => c.PartisanshipId)
                .ToListAsync();
        }

        public async Task<IEnumerable<PositionDegree>> GetAllPositionDegrees()
        {
            return await _db.PositionDegrees
                .Where(c => c.Status == true)
                .OrderBy(c => c.PositionDegreeId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Region>> GetAllRegions()
        {
            return await _db.Regions
                .Where(c => c.Status == true)
                .Include(r => r.Country)
                .OrderBy(c => c.RegionId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Relative>> GetAllRelatives()
        {
            return await _db.Relatives
                .Where(c => c.Status == true)
                .OrderBy(c => c.RelativeId)
                .ToListAsync();
        }

        public async Task<IEnumerable<RelativeWorkingStatus>> GetAllRWStatuses()
        {
            return await _db.RelativeWorkingStatuses
                .Where(c => c.Status == true)
                .OrderBy(c => c.RelativeWorkingStatusId)
                .ToListAsync();
        }

        public async Task<IEnumerable<ScienceDegree>> GetAllScienceDegrees()
        {
            return await _db.ScienceDegrees
                .Where(c => c.Status == true)
                .OrderBy(c => c.ScienceDegreeId)
                .ToListAsync();
        }

        public async Task<IEnumerable<VacationType>> GetAllVacationtypes()
        {
            return await _db.VacationTypes
                .Where(c => c.Status == true)
                .OrderBy(c => c.VacationtypeId)
                .ToListAsync();
        }

        public async Task<Country> GetCountryById(int id)
        {
            return await _db.Countries
                .SingleOrDefaultAsync(c => c.CountryId == id);
        }

        public async Task<DisciplinaryActionType> GetDATypeById(int id)
        {
            return await _db.DisciplinaryActionTypes
                .SingleOrDefaultAsync(d => d.DisciplinaryActionTypeId == id);
        }

        public async Task<DeputyMembership> GetDeputyMembershipById(int id)
        {
            return await _db.DeputyMemberships
                .SingleOrDefaultAsync(d => d.DeputyMembershipId == id);
        }

        public async Task<Disability> GetDisabilityById(int id)
        {
            return await _db.Disabilities
                .SingleOrDefaultAsync(d => d.DisabilityId == id);
        }

        public async Task<District> GetDistrictById(int id)
        {
            return await _db.Districts
                .SingleOrDefaultAsync(d => d.DisrictId == id);
        }

        public async Task<IEnumerable<District>> GetDistrictsByRegionId(int regionId)
        {
            return await _db.Districts
               .Include(d => d.Region)
               .Where(d => d.RegionId == regionId)
               .ToListAsync();
        }

        public async Task<EdInformation> GetEdInfo(int id)
        {
            return await _db.EdInformations
                .SingleOrDefaultAsync(e => e.EdInformationId == id);


        }

        public async Task<Language> GetLanguageById(int id)
        {
            return await _db.Languages
                .SingleOrDefaultAsync(l => l.LanguageId == id);
        }

        public async Task<IEnumerable<Language>> GetLanguagesByUserId(string userId)
        {
            return await _db.Languages
               .Include(d => d.ApplicationUser)
               .Where(d => d.UserId == userId)
               .ToListAsync();
        }

        public async Task<MilitaryTitle> GetMilitaryTitleById(int id)
        {
            return await _db.MilitaryTitles
                .SingleOrDefaultAsync(m => m.MilitaryTitleId == id);
        }

        public async Task<MilitaryServiceStatus> GetMSStatusById(int id)
        {
            return await _db.MilitaryServiceStatuses
                .SingleOrDefaultAsync(m => m.MilitaryServiceStatusId == id);
        }

        public async Task<Nationality> GetNationalityById(int id)
        {
            return await _db.Nationalities
                .SingleOrDefaultAsync(n => n.NationalityId == id);
        }

        public async Task<Partisanship> GetPartisanshipById(int id)
        {
            return await _db.Partisanships
                 .SingleOrDefaultAsync(p => p.PartisanshipId == id);
        }

        public async Task<PositionDegree> GetPositionDegreeById(int id)
        {
            return await _db.PositionDegrees
                .SingleOrDefaultAsync(p => p.PositionDegreeId == id);
        }

        public async Task<Region> GetRegionById(int id)
        {
            return await _db.Regions
                 .SingleOrDefaultAsync(r => r.RegionId == id);
        }

        public async Task<IEnumerable<Region>> GetRegionsByCountryId(int countryId)
        {
            return await _db.Regions
               .Include(r => r.Country)
               .Where(r => r.CountryId== countryId)
               .ToListAsync();
        }

        public async Task<Relative> GetRelativeById(int id)
        {
            return await _db.Relatives
                 .SingleOrDefaultAsync(r => r.RelativeId == id);
        }

        public async Task<RelativeWorkingStatus> GetRWStatusById(int id)
        {
            return await _db.RelativeWorkingStatuses
                 .SingleOrDefaultAsync(r => r.RelativeWorkingStatusId == id);
        }

        public async Task<ScienceDegree> GetScienceDegreeById(int id)
        {
            return await _db.ScienceDegrees
                  .SingleOrDefaultAsync(s => s.ScienceDegreeId == id);
        }

        public async Task<VacationType> GetVacationTypeById(int id)
        {
            return await _db.VacationTypes
                 .SingleOrDefaultAsync(v => v.VacationtypeId == id);
        }

        public async Task UpdateCountry(Country countryToBeUpdated, Country country)
        {
            countryToBeUpdated.CountryName = country.CountryName;
            countryToBeUpdated.Status = country.Status;
           // countryToBeUpdated.CountryId = country.CountryId;

            await _db.SaveChangesAsync();
        }

        public async Task UpdateDAType(DisciplinaryActionType daTypeToBeUpdated, DisciplinaryActionType daType)
        {
            daTypeToBeUpdated.DisciplinaryActionName = daType.DisciplinaryActionName;
            daTypeToBeUpdated.Status = daType.Status;

            await _db.SaveChangesAsync();
        }

        public async Task UpdateDeputyMembership(DeputyMembership deputyMembershipToBeUpdated, DeputyMembership deputyMembership)
        {
            deputyMembershipToBeUpdated.DeputyMembershipName = deputyMembership.DeputyMembershipName;
            deputyMembershipToBeUpdated.Status = deputyMembership.Status;

            await _db.SaveChangesAsync();
        }

        public async Task UpdateDisability(Disability disabilityToBeUpdated, Disability disability)
        {
            disabilityToBeUpdated.DisabilityName = disability.DisabilityName;
            disabilityToBeUpdated.Status = disability.Status;

            await _db.SaveChangesAsync();
        }

        public async Task UpdateDistrict(District districtToBeUpdated, District district)
        {
            districtToBeUpdated.DistrictName = district.DistrictName;
            districtToBeUpdated.RegionId = district.RegionId;
            districtToBeUpdated.Status = district.Status;

            await _db.SaveChangesAsync();
        }

        public async Task UpdateEdInfo(EdInformation edInfoToBeUpdated, EdInformation edInfo)
        {
            edInfoToBeUpdated.EdInformationName = edInfo.EdInformationName;
            edInfoToBeUpdated.Status = edInfo.Status;

            await _db.SaveChangesAsync();
        }

        public async Task UpdateLanguage(Language languageToBeUpdated, Language language)
        {
            languageToBeUpdated.LanguageName = language.LanguageName;
            languageToBeUpdated.Status = language.Status;

            await _db.SaveChangesAsync();
        }

        public async Task UpdateMilitaryTitle(MilitaryTitle militaryTitleToBeUpdated, MilitaryTitle militaryTitle)
        {
            militaryTitleToBeUpdated.MilitaryTitleName = militaryTitle.MilitaryTitleName;
            militaryTitleToBeUpdated.Status = militaryTitle.Status;

            await _db.SaveChangesAsync();
        }

        public async Task UpdateMSStatus(MilitaryServiceStatus msStatusToBeUpdated, MilitaryServiceStatus msStatus)
        {
            msStatusToBeUpdated.MilitaryServiceStatusName = msStatus.MilitaryServiceStatusName;
            msStatusToBeUpdated.Status = msStatus.Status;

            await _db.SaveChangesAsync();
        }

        public async Task UpdateNationality(Nationality nationalityToBeUpdated, Nationality nationality)
        {
            nationalityToBeUpdated.NationalityName = nationality.NationalityName;
            nationalityToBeUpdated.Status = nationality.Status;

            await _db.SaveChangesAsync();
        }

        public async Task UpdatePartisanship(Partisanship partisanshipToBeUpdated, Partisanship partisanship)
        {
            partisanshipToBeUpdated.PartisanshipName = partisanship.PartisanshipName;
            partisanshipToBeUpdated.Status = partisanship.Status;

            await _db.SaveChangesAsync();
        }

        public async Task UpdatePostionDegree(PositionDegree positionDegreeToBeUpdated, PositionDegree positionDegree)
        {
            positionDegreeToBeUpdated.PositionDegreeName = positionDegree.PositionDegreeName;
            positionDegreeToBeUpdated.Status = positionDegree.Status;

            await _db.SaveChangesAsync();
        }

        public async Task UpdateRegion(Region regionToBeUpdated, Region region)
        {
            regionToBeUpdated.RegionName = region.RegionName;
            regionToBeUpdated.CountryId = region.CountryId;
            regionToBeUpdated.Status = region.Status;

            await _db.SaveChangesAsync();
        }

        public async Task UpdateRelative(Relative relativeToBeUpdated, Relative relative)
        {
            relativeToBeUpdated.RelativeName = relative.RelativeName;
            relativeToBeUpdated.Status = relative.Status;

            await _db.SaveChangesAsync();
        }

        public async Task UpdateRWStatus(RelativeWorkingStatus rwStatusToBeUpdated, RelativeWorkingStatus rwStatus)
        {
            rwStatusToBeUpdated.RelativeWorkingStatusName = rwStatus.RelativeWorkingStatusName;
            rwStatusToBeUpdated.Status = rwStatus.Status;

            await _db.SaveChangesAsync();
        }

        public async Task UpdateScienceDegree(ScienceDegree scienceDegreeToBeUpdated, ScienceDegree scienceDegree)
        {
            scienceDegreeToBeUpdated.ScienceDegreeName = scienceDegree.ScienceDegreeName;
            scienceDegreeToBeUpdated.Status = scienceDegree.Status;

            await _db.SaveChangesAsync();
        }

        public async Task UpdateVacationType(VacationType vacationTypeToBeUpdated, VacationType vacationType)
        {
            vacationTypeToBeUpdated.VacationTypeName = vacationType.VacationTypeName;
            vacationTypeToBeUpdated.Status = vacationType.Status;

            await _db.SaveChangesAsync();
        }
    }
}
