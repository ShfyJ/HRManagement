using AutoMapper;
using HRManagement.Services.DataBook;
using HRManagement.Web.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Web.Controllers
{
    public class DataBookController : Controller
    {
        private readonly ILogger<DataBookController> _logger;
        private readonly IDataBookService _dataBookService;
        private readonly IMapper _mapper;

        public DataBookController(IDataBookService dataBookService, IMapper mapper, ILogger<DataBookController> logger)
        {
            _dataBookService = dataBookService;
            _mapper = mapper;
            _logger = logger;
        }

        //Country Databook APIs starts here
        [HttpGet("Countries")]
        public async Task<ActionResult<IEnumerable<CountryResource>>> GetAllCountries()
        {
            _logger.LogInformation("Getting all countries");
            var countries = await _dataBookService.GetAllCountries();
            var countryResources = _mapper.Map<IEnumerable<Models.Country>, IEnumerable<CountryResource>>(countries);

            return Ok(countryResources);
        }

        [HttpGet("Country/{id}")]
        public async Task<ActionResult<CountryResource>> GetCountryById(int id)
        {
            _logger.LogInformation("Getting country by Id");
            var country = await _dataBookService.GetCountryById(id);
            var countryResource = _mapper.Map<Models.Country, CountryResource>(country);

            return Ok(countryResource);
        }

        [HttpPost("Country")]
        public async Task<ActionResult<CountryResource>> AddCountry([FromBody] SaveCountryResource saveCountryResource)
        {
            _logger.LogInformation("Adding new country to DB");
            var countryToAdd = _mapper.Map<SaveCountryResource, Models.Country>(saveCountryResource);

            var newCountry= await _dataBookService.AddCountry(countryToAdd);

            var country = await _dataBookService.GetCountryById(newCountry.CountryId);

            var countryResource = _mapper.Map<Models.Country, CountryResource>(country);

            return Ok(countryResource);
        }

        [HttpPut("Country/{id}")]
        public async Task<ActionResult<CountryResource>> UpdateCountry(int id, [FromBody] SaveCountryResource saveCountryResource)
        {
            _logger.LogInformation("Editing a country");
            var countryToBeUpdate = await _dataBookService.GetCountryById(id);

            if (countryToBeUpdate == null)
                return NotFound();

            var country = _mapper.Map<SaveCountryResource, Models.Country>(saveCountryResource);

            await _dataBookService.UpdateCountry(countryToBeUpdate, country);

            var updatedCountry = await _dataBookService.GetCountryById(id);
            var updatedCountryResource = _mapper.Map<Models.Country, CountryResource>(updatedCountry);

            return Ok(updatedCountryResource);
        }

        [HttpPatch("Country/{id}")]
        public async Task<ActionResult> DeleteCountry(int id)
        {
            _logger.LogInformation("Deleting a Country/changing its status to false");
            if (id == 0)
                return BadRequest();

            await _dataBookService.DeleteCountry(id);

            return NoContent();
        }
        //Country Databook APIs ends here

        //Region Databook APIs starts here

        [HttpGet("Regions")]
        public async Task<ActionResult<IEnumerable<RegionResource>>> GetAllRegions()
        {
            _logger.LogInformation("Getting all regions");
            var regions = await _dataBookService.GetAllRegions();
            var regionResources = _mapper.Map<IEnumerable<Models.Region>, IEnumerable<RegionResource>>(regions);

            return Ok(regionResources);
        }

        [HttpGet("Region/{id}")]
        public async Task<ActionResult<RegionResource>> GetRegionById(int id)
        {   
            //if(identifier == 1)
            //{
            //    await GetRegionsByCountryId(id);
            //}
            _logger.LogInformation("Getting region by Id");
            var region = await _dataBookService.GetRegionById(id);
            var regionResource = _mapper.Map<Models.Region, RegionResource>(region);

            return Ok(regionResource);
        }
        [HttpGet("Regions/{id}")]
        public async Task<ActionResult<IEnumerable<RegionResource>>> GetRegionsByCountryId(int id)
        {
            _logger.LogInformation("Getting region by CountryId");
            var regions = await _dataBookService.GetRegionsByCountryId(id);
            var regionResource = _mapper.Map<IEnumerable<Models.Region>, IEnumerable<RegionResource>>(regions);

            return Ok(regionResource);
        }

        [HttpPost("Region")]
        public async Task<ActionResult<RegionResource>> AddRegion([FromBody] SaveRegionResource saveRegionResource)
        {
            _logger.LogInformation("Adding new country to DB");
            var regionToAdd = _mapper.Map<SaveRegionResource, Models.Region>(saveRegionResource);

            var newRegion= await _dataBookService.AddRegion(regionToAdd);

            var region = await _dataBookService.GetRegionById(newRegion.RegionId);

            var regionResource = _mapper.Map<Models.Region, RegionResource>(region);

            return Ok(regionResource);
        }

        [HttpPut("Region/{id}")]
        public async Task<ActionResult<RegionResource>> UpdateRegion(int id, [FromBody] SaveRegionResource saveRegionResource)
        {
            _logger.LogInformation("Editing a country");
            var regionToBeUpdate = await _dataBookService.GetRegionById(id);

            if (regionToBeUpdate == null)
                return NotFound();

            var region = _mapper.Map<SaveRegionResource, Models.Region>(saveRegionResource);

            await _dataBookService.UpdateRegion(regionToBeUpdate, region);

            var updatedRegion = await _dataBookService.GetRegionById(id);
            var updatedRegionResource = _mapper.Map<Models.Region, RegionResource>(updatedRegion);

            return Ok(updatedRegionResource);
        }
        //Region Databook APIs ends here

        //District Databook APIs starts here
        [HttpGet("Districts")]
        public async Task<ActionResult<IEnumerable<DistrictResource>>> GetAllDistricts()
        {
            _logger.LogInformation("Getting all districts");
            var districts = await _dataBookService.GetAllDistricts();
            var districtResources = _mapper.Map<IEnumerable<Models.District>, IEnumerable<DistrictResource>>(districts);

            return Ok(districtResources);
        }

        [HttpGet("District/{id}")]
        public async Task<ActionResult<DistrictResource>> GetDistrictById(int id)
        {
            _logger.LogInformation("Getting district by Id");
            var district = await _dataBookService.GetDistrictById(id);
            var districtResource = _mapper.Map<Models.District, DistrictResource>(district);

            return Ok(districtResource);
        }

        [HttpGet("Districts/{id}")]
        public async Task<ActionResult<IEnumerable<RegionResource>>> GetDistrictsByRegionId(int id)
        {
            _logger.LogInformation("Getting districts by regionId");
            var districts = await _dataBookService.GetDistrictsByRegionId(id);
            var regionResource = _mapper.Map<IEnumerable<Models.District>, IEnumerable<DistrictResource>>(districts);
            return Ok(districts);
        }

        [HttpPost("District")]
        public async Task<ActionResult<DistrictResource>> AddDistrict([FromBody] SaveDistrictResource saveDistrictResource)
        {
            _logger.LogInformation("Adding new country to DB");
            var districtToAdd = _mapper.Map<SaveDistrictResource, Models.District>(saveDistrictResource);

            var newDistrict = await _dataBookService.AddDistrict(districtToAdd);

            var district = await _dataBookService.GetDistrictById(newDistrict.DisrictId);

            var districtResource = _mapper.Map<Models.District, DistrictResource>(district);

            return Ok(districtResource);
        }

        [HttpPut("District/{id}")]
        public async Task<ActionResult<DistrictResource>> UpdateDistrict(int id, [FromBody] SaveDistrictResource saveDistrictResource)
        {
            _logger.LogInformation("Editing a country");
            var districtToBeUpdate = await _dataBookService.GetDistrictById(id);

            if (districtToBeUpdate == null)
                return NotFound();

            var district = _mapper.Map<SaveDistrictResource, Models.District>(saveDistrictResource);

            await _dataBookService.UpdateDistrict(districtToBeUpdate, district);

            var updatedDistrict = await _dataBookService.GetDistrictById(id);
            var updatedDistrictResource = _mapper.Map<Models.District, DistrictResource>(updatedDistrict);

            return Ok(updatedDistrictResource);
        }

        //District Databook APIs ends here

        //Disability Databook APIs starts here
        [HttpGet("Disabilities")]
        public async Task<ActionResult<IEnumerable<DisabilityResource>>> GetAllDisabilities()
        {
            _logger.LogInformation("Getting all disabilities");
            var disabilities = await _dataBookService.GetAllDisabilities();
            var disabilityResources = _mapper.Map<IEnumerable<Models.Disability>, IEnumerable<DisabilityResource>>(disabilities);

            return Ok(disabilityResources);
        }

        [HttpGet("Disablity/{id}")]
        public async Task<ActionResult<DisabilityResource>> GetDisabilityById(int id)
        {
            _logger.LogInformation("Getting disability by Id");
            var disability = await _dataBookService.GetDisabilityById(id);
            var disabilityResource = _mapper.Map<Models.Disability, DisabilityResource>(disability);

            return Ok(disabilityResource);
        }

        [HttpPost("Disablity")]
        public async Task<ActionResult<DisabilityResource>> AddDisability([FromBody] SaveDisabilityResource saveDisabilityResource)
        {
            _logger.LogInformation("Adding new disablity to DB");
            var disabilityToAdd = _mapper.Map<SaveDisabilityResource, Models.Disability>(saveDisabilityResource);

            var newDisability = await _dataBookService.AddDisability(disabilityToAdd);

            var disability = await _dataBookService.GetDisabilityById(newDisability.DisabilityId);

            var disabilityResource = _mapper.Map<Models.Disability, DisabilityResource>(disability);

            return Ok(disabilityResource);
        }

        [HttpPut("Disability/{id}")]
        public async Task<ActionResult<DisabilityResource>> UpdateDisability(int id, [FromBody] SaveDisabilityResource saveDisabilityResource)
        {
            _logger.LogInformation("Editing a disability");
            var disabilityToBeUpdate = await _dataBookService.GetDisabilityById(id);

            if (disabilityToBeUpdate == null)
                return NotFound();

            var disability = _mapper.Map<SaveDisabilityResource, Models.Disability>(saveDisabilityResource);

            await _dataBookService.UpdateDisability(disabilityToBeUpdate, disability);

            var updatedDisability = await _dataBookService.GetDisabilityById(id);
            var updatedDisabilityResource = _mapper.Map<Models.Disability, DisabilityResource>(updatedDisability);

            return Ok(updatedDisabilityResource);
        }

        //Disability Databook APIs ends here

        //Edinfo Databook APIs starts here
        [HttpGet("EdInfos")]
        public async Task<ActionResult<IEnumerable<EdInformationResource>>> GetAllEdInfos()
        {
            _logger.LogInformation("Getting all EdInformation types");
            var edInfos = await _dataBookService.GetAllEdInfos();
            var edInformationResources = _mapper.Map<IEnumerable<Models.EdInformation>, IEnumerable<EdInformationResource>>(edInfos);

            return Ok(edInformationResources);
        }

        [HttpGet("EdInfo/{id}")]
        public async Task<ActionResult<EdInformationResource>> GetEdInfoById(int id)
        {
            _logger.LogInformation("Getting edInfo by Id");
            var edInfo = await _dataBookService.GetEdInfo(id);
            var edInformationResource = _mapper.Map<Models.EdInformation, EdInformationResource>(edInfo);

            return Ok(edInformationResource);
        }

        [HttpPost("EdInfo")]
        public async Task<ActionResult<EdInformationResource>> AddEdInfo([FromBody] SaveEdInformationResource saveEdInformationResource)
        {
            _logger.LogInformation("Adding new edInfo to DB");
            var edInfoToAdd = _mapper.Map<SaveEdInformationResource, Models.EdInformation>(saveEdInformationResource);

            var newEdInfo = await _dataBookService.AddEdInfo(edInfoToAdd);

            var edInfo = await _dataBookService.GetEdInfo(newEdInfo.EdInformationId);

            var edInformationResource = _mapper.Map<Models.EdInformation, EdInformationResource>(edInfo);

            return Ok(edInformationResource);
        }

        [HttpPut("Disability/{id}")]
        public async Task<ActionResult<EdInformationResource>> UpdateEdInfo(int id, [FromBody] SaveEdInformationResource saveEdInformationResource)
        {
            _logger.LogInformation("Editing a EdInfo");
            var edInfoToBeUpdate = await _dataBookService.GetEdInfo(id);

            if (edInfoToBeUpdate == null)
                return NotFound();

            var edInfo = _mapper.Map<SaveEdInformationResource, Models.EdInformation>(saveEdInformationResource);

            await _dataBookService.UpdateEdInfo(edInfoToBeUpdate, edInfo);

            var updatedEdInfo = await _dataBookService.GetEdInfo(id);
            var updatedEdInfoResource = _mapper.Map<Models.EdInformation, EdInformationResource>(updatedEdInfo);

            return Ok(updatedEdInfoResource);
        }

        //EdInfo Databook APIs ends here

        //Language Databook APIs starts here
        [HttpGet("Languages")]
        public async Task<ActionResult<IEnumerable<LanguageResource>>> GetAllLanguages()
        {
            _logger.LogInformation("Getting all Languages");
            var languages = await _dataBookService.GetAllLanguages();
            var languageResources = _mapper.Map<IEnumerable<Models.Language>, IEnumerable<LanguageResource>>(languages);

            return Ok(languageResources);
        }

        [HttpGet("Language/{id}")]
        public async Task<ActionResult<LanguageResource>> GetLanguageById(int id)
        {
            _logger.LogInformation("Getting languageby Id");
            var language= await _dataBookService.GetLanguageById(id);
            var languageResource = _mapper.Map<Models.Language, LanguageResource>(language);

            return Ok(languageResource);
        }

        [HttpPost("Language")]
        public async Task<ActionResult<LanguageResource>> AddLanguage([FromBody] SaveLanguageResource saveLanguageResource)
        {
            _logger.LogInformation("Adding new language to DB");
            var languageToAdd = _mapper.Map<SaveLanguageResource, Models.Language>(saveLanguageResource);

            var newLanguage = await _dataBookService.AddLanguage(languageToAdd);

            var language = await _dataBookService.GetLanguageById(newLanguage.LanguageId);

            var languageResource = _mapper.Map<Models.Language, LanguageResource>(language);

            return Ok(languageResource);
        }

        [HttpPut("Language/{id}")]
        public async Task<ActionResult<LanguageResource>> UpdateLanguage(int id, [FromBody] SaveLanguageResource saveLanguageResource)
        {
            _logger.LogInformation("Editing a Language");
            var languageToBeUpdate = await _dataBookService.GetLanguageById(id);

            if (languageToBeUpdate == null)
                return NotFound();

            var language = _mapper.Map<SaveLanguageResource, Models.Language>(saveLanguageResource);

            await _dataBookService.UpdateLanguage(languageToBeUpdate, language);

            var updatedLanguage = await _dataBookService.GetLanguageById(id);
            var updatedLanguageResource = _mapper.Map<Models.Language, LanguageResource>(updatedLanguage);

            return Ok(updatedLanguageResource);
        }

        //Language Databook APIs ends here

        //MilitaryServiceStatus Databook APIs starts here
        [HttpGet("MilitaryServiceStatuses")]
        public async Task<ActionResult<IEnumerable<MilitaryServiceStatusResource>>> GetAllMSStatuses()
        {
            _logger.LogInformation("Getting all militaryServiceStatuses");
            var msStatuses = await _dataBookService.GetAllMSStatuses();
            var msStatusResources = _mapper.Map<IEnumerable<Models.MilitaryServiceStatus>, IEnumerable<MilitaryServiceStatusResource>>(msStatuses);

            return Ok(msStatusResources);
        }

        [HttpGet("MilitaryServiceStatus/{id}")]
        public async Task<ActionResult<MilitaryServiceStatusResource>> GetMSStatusById(int id)
        {
            _logger.LogInformation("Getting militaryServiceStatus by Id");
            var msStatus = await _dataBookService.GetMSStatusById(id);
            var msStatusResource = _mapper.Map<Models.MilitaryServiceStatus, MilitaryServiceStatusResource>(msStatus);

            return Ok(msStatusResource);
        }

        [HttpPost("MilitaryServiceStatus")]
        public async Task<ActionResult<MilitaryServiceStatusResource>> AddMSStatus([FromBody] SaveMilitaryServiceResource saveMilitaryServiceResource)
        {
            _logger.LogInformation("Adding new militaryServiceStatus to DB");
            var msStatusToAdd = _mapper.Map<SaveMilitaryServiceResource, Models.MilitaryServiceStatus>(saveMilitaryServiceResource);

            var newMSStatus = await _dataBookService.AddMSStatus(msStatusToAdd);

            var msStatus = await _dataBookService.GetMSStatusById(newMSStatus.MilitaryServiceStatusId);

            var msStatusResource = _mapper.Map<Models.MilitaryServiceStatus, MilitaryServiceStatusResource>(msStatus);

            return Ok(msStatusResource);
        }

        [HttpPut("MilitaryServiceStatus/{id}")]
        public async Task<ActionResult<MilitaryServiceStatusResource>> UpdateMSStatus(int id, [FromBody] SaveMilitaryServiceResource saveMilitaryServiceResource)
        {
            _logger.LogInformation("Editing a msStatus");
            var msStatusToBeUpdate = await _dataBookService.GetMSStatusById(id);

            if (msStatusToBeUpdate == null)
                return NotFound();

            var msStatus = _mapper.Map<SaveMilitaryServiceResource, Models.MilitaryServiceStatus>(saveMilitaryServiceResource);

            await _dataBookService.UpdateMSStatus(msStatusToBeUpdate, msStatus);

            var updatedMSStatus = await _dataBookService.GetMSStatusById(id);
            var updatedMSStatusResource = _mapper.Map<Models.MilitaryServiceStatus, MilitaryServiceStatusResource>(updatedMSStatus);

            return Ok(updatedMSStatusResource);
        }

        //MilitaryServiceStatus Databook APIs ends here

        //MilitaryTitle Databook APIs starts here
        [HttpGet("MilitaryTitles")]
        public async Task<ActionResult<IEnumerable<MilitaryTitleResource>>> GetAllMilitaryTitles()
        {
            _logger.LogInformation("Getting all militaryServiceStatuses");
            var militaryTitle = await _dataBookService.GetAllMilitaryTitles();
            var militaryTitleResources = _mapper.Map<IEnumerable<Models.MilitaryTitle>, IEnumerable<MilitaryTitleResource>>(militaryTitle);

            return Ok(militaryTitleResources);
        }

        [HttpGet("MilitaryTitle/{id}")]
        public async Task<ActionResult<MilitaryTitleResource>> GetMilitaryTitleById(int id)
        {
            _logger.LogInformation("Getting militaryTitle by Id");
            var militaryTitle = await _dataBookService.GetMilitaryTitleById(id);
            var militaryTitleResource = _mapper.Map<Models.MilitaryTitle, MilitaryTitleResource>(militaryTitle);

            return Ok(militaryTitleResource);
        }

        [HttpPost("MilitaryTitle")]
        public async Task<ActionResult<MilitaryTitleResource>> AddMSStatus([FromBody] SaveMilitaryTitleResource saveMilitaryTitleResource)
        {
            _logger.LogInformation("Adding new militaryTitle to DB");
            var militaryTitleToAdd = _mapper.Map<SaveMilitaryTitleResource, Models.MilitaryTitle>(saveMilitaryTitleResource);

            var newMilitaryTitle = await _dataBookService.AddMilitaryTitle(militaryTitleToAdd);

            var militaryTitle = await _dataBookService.GetMilitaryTitleById(newMilitaryTitle.MilitaryTitleId);

            var militaryTitleResource = _mapper.Map<Models.MilitaryTitle, MilitaryTitleResource>(militaryTitle);

            return Ok(militaryTitleResource);
        }

        [HttpPut("MilitaryTitle/{id}")]
        public async Task<ActionResult<MilitaryTitleResource>> UpdateMSStatus(int id, [FromBody] SaveMilitaryTitleResource saveMilitaryTitleResource)
        {
            _logger.LogInformation("Editing a militaryTitle");
            var militaryTitleToBeUpdate = await _dataBookService.GetMilitaryTitleById(id);

            if (militaryTitleToBeUpdate == null)
                return NotFound();

            var militaryTitle = _mapper.Map<SaveMilitaryTitleResource, Models.MilitaryTitle>(saveMilitaryTitleResource);

            await _dataBookService.UpdateMilitaryTitle(militaryTitleToBeUpdate, militaryTitle);

            var updatedMilitaryTitle = await _dataBookService.GetMilitaryTitleById(id);
            var updatedMilitaryTitleResource = _mapper.Map<Models.MilitaryTitle, MilitaryTitleResource>(updatedMilitaryTitle);

            return Ok(updatedMilitaryTitleResource);
        }

        //MilitaryTitle Databook APIs ends here

        //Nationality Databook APIs starts here
        [HttpGet("Nationalities")]
        public async Task<ActionResult<IEnumerable<NationalityResource>>> GetAllNationalities()
        {
            _logger.LogInformation("Getting all nationalities");
            var nationalities = await _dataBookService.GetAllNationalities();
            var nationalityResources = _mapper.Map<IEnumerable<Models.Nationality>, IEnumerable<NationalityResource>>(nationalities);

            return Ok(nationalityResources);
        }

        [HttpGet("Nationality/{id}")]
        public async Task<ActionResult<NationalityResource>> GetNationalityById(int id)
        {
            _logger.LogInformation("Getting nationality by Id");
            var nationality = await _dataBookService.GetNationalityById(id);
            var nationalityResource = _mapper.Map<Models.Nationality, NationalityResource>(nationality);

            return Ok(nationalityResource);
        }

        [HttpPost("MilitaryTitle")]
        public async Task<ActionResult<NationalityResource>> AddNationality([FromBody] SaveNationalityResource saveNationalityResource)
        {
            _logger.LogInformation("Adding new nationality to DB");
            var nationalityToAdd = _mapper.Map<SaveNationalityResource, Models.Nationality>(saveNationalityResource);

            var newNationality = await _dataBookService.AddNationality(nationalityToAdd);

            var nationality = await _dataBookService.GetNationalityById(newNationality.NationalityId);

            var nationalityResource = _mapper.Map<Models.Nationality, NationalityResource>(nationality);

            return Ok(nationalityResource);
        }

        [HttpPut("Nationality/{id}")]
        public async Task<ActionResult<NationalityResource>> UpdateNationality(int id, [FromBody] SaveNationalityResource saveNationalityResource)
        {
            _logger.LogInformation("Editing a nationality");
            var nationalityToBeUpdate = await _dataBookService.GetNationalityById(id);

            if (nationalityToBeUpdate == null)
                return NotFound();

            var nationality = _mapper.Map<SaveNationalityResource, Models.Nationality>(saveNationalityResource);

            await _dataBookService.UpdateNationality(nationalityToBeUpdate, nationality);

            var updatedNationality = await _dataBookService.GetNationalityById(id);
            var updatedNationalityResource = _mapper.Map<Models.Nationality, NationalityResource>(updatedNationality);

            return Ok(updatedNationalityResource);
        }

        //Nationality Databook APIs ends here

        //Partisanship Databook APIs starts here
        [HttpGet("Partisanships")]
        public async Task<ActionResult<IEnumerable<PartisanshipResource>>> GetAllPartisanships()
        {
            _logger.LogInformation("Getting all partisanships");
            var partisanships = await _dataBookService.GetAllPartisanships();
            var partisanshipResources = _mapper.Map<IEnumerable<Models.Partisanship>, IEnumerable<PartisanshipResource>>(partisanships);

            return Ok(partisanshipResources);
        }

        [HttpGet("Partisanship/{id}")]
        public async Task<ActionResult<PartisanshipResource>> GetPartisanshipById(int id)
        {
            _logger.LogInformation("Getting partisanship by Id");
            var partisanship = await _dataBookService.GetPartisanshipById(id);
            var partisanshipResource = _mapper.Map<Models.Partisanship, PartisanshipResource>(partisanship);

            return Ok(partisanshipResource);
        }

        [HttpPost("Partisanship")]
        public async Task<ActionResult<NationalityResource>> AddPartisanship([FromBody] SavePartisanshipResource savePartisanshipResource)
        {
            _logger.LogInformation("Adding new partisanship to DB");
            var partisanshipToAdd = _mapper.Map<SavePartisanshipResource, Models.Partisanship>(savePartisanshipResource);

            var newPartisanship = await _dataBookService.AddPartisanship(partisanshipToAdd);

            var partisanship = await _dataBookService.GetPartisanshipById(newPartisanship.PartisanshipId);

            var partisanshipResource = _mapper.Map<Models.Partisanship, PartisanshipResource>(partisanship);

            return Ok(partisanshipResource);
        }

        [HttpPut("Partisanship/{id}")]
        public async Task<ActionResult<PartisanshipResource>> UpdatePartisanship(int id, [FromBody] SavePartisanshipResource savePartisanshipResource)
        {
            _logger.LogInformation("Editing a partisanship");
            var partisanshipToBeUpdate = await _dataBookService.GetPartisanshipById(id);

            if (partisanshipToBeUpdate == null)
                return NotFound();

            var partisanship = _mapper.Map<SavePartisanshipResource, Models.Partisanship>(savePartisanshipResource);

            await _dataBookService.UpdatePartisanship(partisanshipToBeUpdate, partisanship);

            var updatedPartisanship = await _dataBookService.GetPartisanshipById(id);
            var updatedPartisanshipResource = _mapper.Map<Models.Partisanship, PartisanshipResource>(updatedPartisanship);

            return Ok(updatedPartisanshipResource);
        }

        //Partisanship Databook APIs ends here

        //PositionDegree Databook APIs starts here
        [HttpGet("PositionDegrees")]
        public async Task<ActionResult<IEnumerable<PositionDegreeResource>>> GetAllPositionDegrees()
        {
            _logger.LogInformation("Getting all positionDegrees");
            var positionDegrees = await _dataBookService.GetAllPositionDegrees();
            var positionDegreeResources = _mapper.Map<IEnumerable<Models.PositionDegree>, IEnumerable<PositionDegreeResource>>(positionDegrees);

            return Ok(positionDegreeResources);
        }

        [HttpGet("PositionDegree/{id}")]
        public async Task<ActionResult<PositionDegreeResource>> GetPositionDegreeById(int id)
        {
            _logger.LogInformation("Getting positionDegree by Id");
            var positionDegree = await _dataBookService.GetPositionDegreeById(id);
            var positionDegreeResource = _mapper.Map<Models.PositionDegree, PositionDegreeResource>(positionDegree);

            return Ok(positionDegreeResource);
        }

        [HttpPost("PositionDegree")]
        public async Task<ActionResult<PositionDegreeResource>> AddPositionDegree([FromBody] SavePositionDegree savePositionDegreeResource)
        {
            _logger.LogInformation("Adding new positionDegree to DB");
            var positionDegreeToAdd = _mapper.Map<SavePositionDegree, Models.PositionDegree>(savePositionDegreeResource);

            var newPositionDegree = await _dataBookService.AddPostionDegree(positionDegreeToAdd);

            var positionDegree = await _dataBookService.GetPositionDegreeById(newPositionDegree.PositionDegreeId);

            var positionDegreeResource = _mapper.Map<Models.PositionDegree, PositionDegreeResource>(positionDegree);

            return Ok(positionDegreeResource);
        }

        [HttpPut("PositionDegree/{id}")]
        public async Task<ActionResult<PositionDegreeResource>> UpdatePositionDegree(int id, [FromBody] SavePositionDegree savePositionDegreeResource)
        {
            _logger.LogInformation("Editing a positionDegree");
            var positionDegreeToBeUpdate = await _dataBookService.GetPositionDegreeById(id);

            if (positionDegreeToBeUpdate == null)
                return NotFound();

            var positionDegree = _mapper.Map<SavePositionDegree, Models.PositionDegree>(savePositionDegreeResource);

            await _dataBookService.UpdatePostionDegree(positionDegreeToBeUpdate, positionDegree);

            var updatedPositionDegree = await _dataBookService.GetPositionDegreeById(id);
            var updatedPositionDegreeResource = _mapper.Map<Models.PositionDegree, PositionDegreeResource>(updatedPositionDegree);

            return Ok(updatedPositionDegreeResource);
        }

        //PositionDegree Databook APIs ends here

        //Relative Databook APIs starts here
        [HttpGet("Relatives")]
        public async Task<ActionResult<IEnumerable<RelativeResource>>> GetAllRelatives()
        {
            _logger.LogInformation("Getting all relatives");
            var relatives = await _dataBookService.GetAllRelatives();
            var relativeResources = _mapper.Map<IEnumerable<Models.Relative>, IEnumerable<RelativeResource>>(relatives);

            return Ok(relativeResources);
        }

        [HttpGet("Relative/{id}")]
        public async Task<ActionResult<RelativeResource>> GetRelativeById(int id)
        {
            _logger.LogInformation("Getting relative by Id");
            var relative = await _dataBookService.GetRelativeById(id);
            var relativeResource = _mapper.Map<Models.Relative, RelativeResource>(relative);

            return Ok(relativeResource);
        }

        [HttpPost("Relative")]
        public async Task<ActionResult<RelativeResource>> AddRelative([FromBody] SaveRelativeResource saveRelativeResource)
        {
            _logger.LogInformation("Adding new relative to DB");
            var relativeToAdd = _mapper.Map<SaveRelativeResource, Models.Relative>(saveRelativeResource);

            var newRelative = await _dataBookService.AddRelative(relativeToAdd);

            var relative = await _dataBookService.GetRelativeById(newRelative.RelativeId);

            var relativeResource = _mapper.Map<Models.Relative, RelativeResource>(relative);

            return Ok(relativeResource);
        }

        [HttpPut("Relative/{id}")]
        public async Task<ActionResult<RelativeResource>> UpdateRelative(int id, [FromBody] SaveRelativeResource saveRelativeResource)
        {
            _logger.LogInformation("Editing a relative");
            var relativeToBeUpdate = await _dataBookService.GetRelativeById(id);

            if (relativeToBeUpdate == null)
                return NotFound();

            var relative = _mapper.Map<SaveRelativeResource, Models.Relative>(saveRelativeResource);

            await _dataBookService.UpdateRelative(relativeToBeUpdate, relative);

            var updatedRelative = await _dataBookService.GetRelativeById(id);
            var updatedRelativeResource = _mapper.Map<Models.Relative, RelativeResource>(updatedRelative);

            return Ok(updatedRelativeResource);
        }

        //Relative Databook APIs ends here

        //RelativeWorkingStatus Databook APIs starts here
        [HttpGet("RelativeWorkingStatuses")]
        public async Task<ActionResult<IEnumerable<RelativeWorkingStatusResource>>> GetAllRWStatuses()
        {
            _logger.LogInformation("Getting all relativeWorkingStatuses");
            var relativeWorkingStatuses = await _dataBookService.GetAllRWStatuses();
            var relativeWorkingStatusResources = _mapper.Map<IEnumerable<Models.RelativeWorkingStatus>, IEnumerable<RelativeWorkingStatusResource>>(relativeWorkingStatuses);

            return Ok(relativeWorkingStatusResources);
        }

        [HttpGet("RelativeWorkingStatus/{id}")]
        public async Task<ActionResult<RelativeWorkingStatusResource>> GetRWStatusById(int id)
        {
            _logger.LogInformation("Getting v by Id");
            var relativeWorkingStatus = await _dataBookService.GetRWStatusById(id);
            var relativeWorkingStatusResource = _mapper.Map<Models.RelativeWorkingStatus, RelativeWorkingStatusResource>(relativeWorkingStatus);

            return Ok(relativeWorkingStatusResource);
        }

        [HttpPost("RelativeWorkingStatus")]
        public async Task<ActionResult<RelativeWorkingStatusResource>> AddRelative([FromBody] SaveRelativeWorkingStatusResource saveRelativeWorkingStatusResource)
        {
            _logger.LogInformation("Adding new relativeWorkingStatus to DB");
            var relativeWorkingStatusToAdd = _mapper.Map<SaveRelativeWorkingStatusResource, Models.RelativeWorkingStatus>(saveRelativeWorkingStatusResource);

            var newRelativeWorkingStatus = await _dataBookService.AddRWStatus(relativeWorkingStatusToAdd);

            var relativeWorkingStatus = await _dataBookService.GetRWStatusById(newRelativeWorkingStatus.RelativeWorkingStatusId);

            var relativeWorkingStatusResource = _mapper.Map<Models.RelativeWorkingStatus, RelativeWorkingStatusResource>(relativeWorkingStatus);

            return Ok(relativeWorkingStatusResource);
        }

        [HttpPut("RelativeWorkingStatus/{id}")]
        public async Task<ActionResult<RelativeWorkingStatusResource>> UpdateRWStatus(int id, [FromBody] SaveRelativeWorkingStatusResource saveRelativeWorkingStatusResource)
        {
            _logger.LogInformation("Editing a relativeWorkingStatus");
            var relativeWorkingStatusToBeUpdate = await _dataBookService.GetRWStatusById(id);

            if (relativeWorkingStatusToBeUpdate == null)
                return NotFound();

            var relativeWorkingStatus = _mapper.Map<SaveRelativeWorkingStatusResource, Models.RelativeWorkingStatus>(saveRelativeWorkingStatusResource);

            await _dataBookService.UpdateRWStatus(relativeWorkingStatusToBeUpdate, relativeWorkingStatus);

            var updatedRelativeWorkingStatus = await _dataBookService.GetRWStatusById(id);
            var updatedRelativeWorkingStatusResource = _mapper.Map<Models.RelativeWorkingStatus, RelativeWorkingStatusResource>(updatedRelativeWorkingStatus);

            return Ok(updatedRelativeWorkingStatusResource);
        }

        //RelativeWorkingStatus APIs ends here

        //ScienceDegree Databook APIs starts here
        [HttpGet("ScienceDegrees")]
        public async Task<ActionResult<IEnumerable<ScienceDegreeResource>>> GetAllScienceDegrees()
        {
            _logger.LogInformation("Getting all scienceDegrees");
            var scienceDegrees = await _dataBookService.GetAllScienceDegrees();
            var scienceDegreeResources = _mapper.Map<IEnumerable<Models.ScienceDegree>, IEnumerable<ScienceDegreeResource>>(scienceDegrees);

            return Ok(scienceDegreeResources);
        }

        [HttpGet("ScienceDegree/{id}")]
        public async Task<ActionResult<ScienceDegreeResource>> GetScienceDegreeById(int id)
        {
            _logger.LogInformation("Getting scienceDegree by Id");
            var scienceDegree = await _dataBookService.GetScienceDegreeById(id);
            var scienceDegreeResource = _mapper.Map<Models.ScienceDegree, ScienceDegreeResource>(scienceDegree);

            return Ok(scienceDegreeResource);
        }

        [HttpPost("ScienceDegree")]
        public async Task<ActionResult<ScienceDegreeResource>> AddScienceDegree([FromBody] SaveScienceDegreeResource saveScienceDegreeResource)
        {
            _logger.LogInformation("Adding new scienceDegree to DB");
            var scienceDegreeToAdd = _mapper.Map<SaveScienceDegreeResource, Models.ScienceDegree>(saveScienceDegreeResource);

            var newScienceDegree = await _dataBookService.AddScienceDegree(scienceDegreeToAdd);

            var scienceDegree = await _dataBookService.GetScienceDegreeById(newScienceDegree.ScienceDegreeId);

            var scienceDegreeResource = _mapper.Map<Models.ScienceDegree, ScienceDegreeResource>(scienceDegree);

            return Ok(scienceDegreeResource);
        }

        [HttpPut("ScienceDegree/{id}")]
        public async Task<ActionResult<ScienceDegreeResource>> UpdateScienceDegree(int id, [FromBody] SaveScienceDegreeResource saveScienceDegreeResource)
        {
            _logger.LogInformation("Editing a scienceDegree");
            var scienceDegreeToBeUpdate = await _dataBookService.GetScienceDegreeById(id);

            if (scienceDegreeToBeUpdate == null)
                return NotFound();

            var scienceDegree = _mapper.Map<SaveScienceDegreeResource, Models.ScienceDegree>(saveScienceDegreeResource);

            await _dataBookService.UpdateScienceDegree(scienceDegreeToBeUpdate, scienceDegree);

            var updatedScienceDegree = await _dataBookService.GetScienceDegreeById(id);
            var updatedScienceDegreeResource = _mapper.Map<Models.ScienceDegree, ScienceDegreeResource>(updatedScienceDegree);

            return Ok(updatedScienceDegreeResource);
        }

        //ScienceDegree APIs ends here

        //Vacationtype Databook APIs starts here
        [HttpGet("VacationTypes")]
        public async Task<ActionResult<IEnumerable<VacationTypeResource>>> GetAllVacationTypes()
        {
            _logger.LogInformation("Getting all vacationTypes");
            var vacationTypes = await _dataBookService.GetAllVacationtypes();
            var vacationTypeResources = _mapper.Map<IEnumerable<Models.VacationType>, IEnumerable<VacationTypeResource>>(vacationTypes);

            return Ok(vacationTypeResources);
        }

        [HttpGet("VacationType/{id}")]
        public async Task<ActionResult<VacationTypeResource>> GetVacationTypeById(int id)
        {
            _logger.LogInformation("Getting vacationType by Id");
            var vacationType = await _dataBookService.GetVacationTypeById(id);
            var vacationTypeResource = _mapper.Map<Models.VacationType, VacationTypeResource>(vacationType);

            return Ok(vacationTypeResource);
        }

        [HttpPost("VacationType")]
        public async Task<ActionResult<ScienceDegreeResource>> AddVacationType([FromBody] SaveVacationTypeResource saveVacationTypeResource)
        {
            _logger.LogInformation("Adding new vacationType to DB");
            var vacationTypeToAdd = _mapper.Map<SaveVacationTypeResource, Models.VacationType>(saveVacationTypeResource);

            var newVacationType = await _dataBookService.AddVacationType(vacationTypeToAdd);

            var vacationType = await _dataBookService.GetVacationTypeById(newVacationType.VacationtypeId);

            var vacationTypeResource = _mapper.Map<Models.VacationType, VacationTypeResource>(vacationType);

            return Ok(vacationTypeResource);
        }

        [HttpPut("VacationType/{id}")]
        public async Task<ActionResult<VacationTypeResource>> UpdateVacationType(int id, [FromBody] SaveVacationTypeResource saveVacationTypeResource)
        {
            _logger.LogInformation("Editing a vacationType");
            var vacationTypeToBeUpdate = await _dataBookService.GetVacationTypeById(id);

            if (vacationTypeToBeUpdate == null)
                return NotFound();

            var vacationType = _mapper.Map<SaveVacationTypeResource, Models.VacationType>(saveVacationTypeResource);

            await _dataBookService.UpdateVacationType(vacationTypeToBeUpdate, vacationType);

            var updatedVacationType = await _dataBookService.GetVacationTypeById(id);
            var updatedVacationTypeResource = _mapper.Map<Models.VacationType, VacationTypeResource>(updatedVacationType);

            return Ok(updatedVacationTypeResource);
        }

        //ScienceDegree APIs ends here
    }

}
