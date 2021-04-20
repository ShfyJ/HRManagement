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

        [HttpGet("Countries")]
        public async Task<ActionResult<IEnumerable<CountryResource>>> GetAllCountries()
        {
            _logger.LogInformation("Getting all countries");
            var countries = await _dataBookService.GetAllCountries();
            var countryResources = _mapper.Map<IEnumerable<Models.Country>, IEnumerable<CountryResource>>(countries);

            return Ok(countryResources);
        }

        [HttpGet("Country{id}")]
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

        [HttpPut("Country{id}")]
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

        [HttpPatch("Country{id}")]
        public async Task<ActionResult> DeleteCountry(int id)
        {
            _logger.LogInformation("Deleting a Country/changing its status to false");
            if (id == 0)
                return BadRequest();

            await _dataBookService.DeleteCountry(id);

            return NoContent();
        }
    }

}
