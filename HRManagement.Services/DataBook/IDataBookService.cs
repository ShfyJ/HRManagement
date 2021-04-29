using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Services.DataBook
{
    public interface IDataBookService
    {
        //Country databook actions
        Task<IEnumerable<Models.Country>> GetAllCountries();
        Task<Models.Country> GetCountryById(int id);
        Task<Models.Country> AddCountry(Models.Country newCountry);
        Task UpdateCountry(Models.Country countryToBeUpdated, Models.Country country);
        Task DeleteCountry(int id);

        //Region databook actions
        Task<IEnumerable<Models.Region>> GetAllRegions();
        Task<Models.Region> GetRegionById(int id);
        Task<IEnumerable<Models.Region>> GetRegionsByCountryId(int countryId);
        Task<Models.Region> AddRegion(Models.Region newRegion);
        Task UpdateRegion(Models.Region regionToBeUpdated, Models.Region region);
        Task DeleteRegion(int id);

        //District databook actions
        Task<IEnumerable<Models.District>> GetAllDistricts();
        Task<Models.District> GetDistrictById(int id);
        Task<IEnumerable<Models.District>> GetDistrictsByRegionId(int regionId);
        Task<Models.District> AddDistrict(Models.District newDistrict);
        Task UpdateDistrict(Models.District districtToBeUpdated, Models.District district);
        Task DeleteDistrict(int id);

        //Disabilities databook actions
        Task<IEnumerable<Models.Disability>> GetAllDisabilities();
        Task<Models.Disability> GetDisabilityById(int id);
        Task<Models.Disability> AddDisability(Models.Disability newDisability);
        Task UpdateDisability(Models.Disability disabilityToBeUpdated, Models.Disability disability);
        Task DeleteDisability(int id);

        //Languages databook actions
        Task<IEnumerable<Models.Language>> GetAllLanguages();
        Task<Models.Language> GetLanguageById(int id);
        Task<IEnumerable<Models.Language>> GetLanguagesByUserId(string userId);
        Task<Models.Language> AddLanguage(Models.Language newLanguage);
        Task UpdateLanguage(Models.Language languageToBeUpdated, Models.Language language);
        Task DeleteLanguage(int id);

        //MilitaryServiceStatuses databook actions
        Task<IEnumerable<Models.MilitaryServiceStatus>> GetAllMSStatuses();
        Task<Models.MilitaryServiceStatus> GetMSStatusById(int id);
        Task<Models.MilitaryServiceStatus> AddMSStatus(Models.MilitaryServiceStatus newMSStatus);
        Task UpdateMSStatus(Models.MilitaryServiceStatus msStatusToBeUpdated, Models.MilitaryServiceStatus msStatus);
        Task DeleteMSStatus(int id);

        //MilitaryTitles databook actions
        Task<IEnumerable<Models.MilitaryTitle>> GetAllMilitaryTitles();
        Task<Models.MilitaryTitle> GetMilitaryTitleById(int id);
        Task<Models.MilitaryTitle> AddMilitaryTitle(Models.MilitaryTitle newMilitaryTitle);
        Task UpdateMilitaryTitle(Models.MilitaryTitle militaryTitleToBeUpdated, Models.MilitaryTitle militaryTitle);
        Task DeleteMilitaryTitle(int id);

        //Nationalities databook actions
        Task<IEnumerable<Models.Nationality>> GetAllNationalities();
        Task<Models.Nationality> GetNationalityById(int id);
        Task<Models.Nationality> AddNationality(Models.Nationality newNationality);
        Task UpdateNationality(Models.Nationality nationalityToBeUpdated, Models.Nationality nationality);
        Task DeleteNationality(int id);

        //Partisanships databook actions
        Task<IEnumerable<Models.Partisanship>> GetAllPartisanships();
        Task<Models.Partisanship> GetPartisanshipById(int id);
        Task<Models.Partisanship> AddPartisanship(Models.Partisanship newPartisanship);
        Task UpdatePartisanship(Models.Partisanship partisanshipToBeUpdated, Models.Partisanship partisanship);
        Task DeletePartisanship(int id);

        //PostionDegrees databook actions //lavozim darajasi ex:AUP,UP,Texnik xodim, ishlab chiqarish, xizmat ko'ratish
        Task<IEnumerable<Models.PositionDegree>> GetAllPositionDegrees();
        Task<Models.PositionDegree> GetPositionDegreeById(int id);
        Task<Models.PositionDegree> AddPostionDegree(Models.PositionDegree newPositionDegree);
        Task UpdatePostionDegree(Models.PositionDegree positionDegreeToBeUpdated, Models.PositionDegree positionDegree);
        Task DeletePositionDegree(int id);

        //Relatives databook actions
        Task<IEnumerable<Models.Relative>> GetAllRelatives();
        Task<Models.Relative> GetRelativeById(int id);
        Task<Models.Relative> AddRelative(Models.Relative newRelative);
        Task UpdateRelative(Models.Relative relativeToBeUpdated, Models.Relative relative);
        Task DeleteRelative(int id);

        //RelativeWorkingStatus databook actions //hozirda ishlaydi, nafaqada, uy bekasi, talaba, ...
        Task<IEnumerable<Models.RelativeWorkingStatus>> GetAllRWStatuses();
        Task<Models.RelativeWorkingStatus> GetRWStatusById(int id);
        Task<Models.RelativeWorkingStatus> AddRWStatus(Models.RelativeWorkingStatus newRWStatus);
        Task UpdateRWStatus(Models.RelativeWorkingStatus rwStatusToBeUpdated, Models.RelativeWorkingStatus rwStatus);
        Task DeleteRWStatus(int id);

        //ScienceDegrees databook actions
        Task<IEnumerable<Models.ScienceDegree>> GetAllScienceDegrees();
        Task<Models.ScienceDegree> GetScienceDegreeById(int id);
        Task<Models.ScienceDegree> AddScienceDegree(Models.ScienceDegree newScienceDegree);
        Task UpdateScienceDegree(Models.ScienceDegree scienceDegreeToBeUpdated, Models.ScienceDegree scienceDegree);
        Task DeleteScienceDegree(int id);

        //VacationTypes databook actions
        Task<IEnumerable<Models.VacationType>> GetAllVacationtypes();
        Task<Models.VacationType> GetVacationTypeById(int id);
        Task<Models.VacationType> AddVacationType(Models.VacationType newVacationType);
        Task UpdateVacationType(Models.VacationType vacationTypeToBeUpdated, Models.VacationType vacationType);
        Task DeleteVacationType(int id);

        //DisciplanaryActiontypes databook actions
        Task<IEnumerable<Models.DisciplinaryActionType>> GetAllDATypes();
        Task<Models.DisciplinaryActionType> GetDATypeById(int id);
        Task<Models.DisciplinaryActionType> AddDAType(Models.DisciplinaryActionType newDAtype);
        Task UpdateDAType(Models.DisciplinaryActionType daTypeToBeUpdated, Models.DisciplinaryActionType daType);
        Task DeleteDAType(int id);

        //Edinformation databook actions //(oliy, o'rta, o'rta-maxsus ..)
        Task<IEnumerable<Models.EdInformation>> GetAllEdInfos();
        Task<Models.EdInformation> GetEdInfo(int id);
        Task<Models.EdInformation> AddEdInfo(Models.EdInformation newEdInfo);
        Task UpdateEdInfo(Models.EdInformation edInfoToBeUpdated, Models.EdInformation edInfo);
        Task DeleteEdInfo(int id);
        
    }
}
