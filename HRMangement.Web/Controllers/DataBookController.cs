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
    }

}
