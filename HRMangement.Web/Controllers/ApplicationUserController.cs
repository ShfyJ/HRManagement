using AutoMapper;
using HRManagement.Models;
using HRManagement.Services.ApplicationUser;
using HRManagement.Web.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRMangement.Web.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly ILogger<ApplicationUserController> _logger;
        private readonly IApplicationUserService _applicationUserService;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUserController(ILogger<ApplicationUserController> logger,
            IApplicationUserService applicationUserService, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _applicationUserService = applicationUserService;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet("/api/applicationuser")]
        public async Task<ActionResult> GetAllUsersWithAllInfos()
        {
            _logger.LogInformation("Getting all users");
            var applicationUsers = await _applicationUserService.GetAllUsersWithAllInfos();

            return Ok(applicationUsers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationUserResource>> GetApplicationUserById(string id)
        {
            var applicationUser = await _applicationUserService.GetUserById(id);
            var applicationUserResource = _mapper.Map<ApplicationUser, ApplicationUserResource>(applicationUser);

            return Ok(applicationUserResource);
        }


        [HttpPost("/api/applicationuser")]
        public async Task<ActionResult<ApplicationUserResource>> CreateUser([FromBody] SaveApplicationUserResource saveApplicationUserResource)
        {
            _logger.LogInformation("Create a new user");

            var userToCreate = _mapper.Map<SaveApplicationUserResource, ApplicationUser>(saveApplicationUserResource);

            //var newUser = await _applicationUserService.CreateUser(userToCreate);
            var userCreateResult = await _userManager.CreateAsync(userToCreate, saveApplicationUserResource.Password);

            //var user = await _applicationUserService.GetUserById(userCreateResult.Data.Id);

            //var applicationUserResource = _mapper.Map<ApplicationUser, ApplicationUserResource>(user);

            //return Ok(applicationUserResource);
            if (userCreateResult.Succeeded)

            {
                return Created(string.Empty, string.Empty);
            }

            return Problem(userCreateResult.Errors.First().Description, null, 500);
        }

        [HttpPatch("/api/applicationuser/{id}")]
        public ActionResult DismissUser(string id)
        {
            _logger.LogInformation("Dismiss a user");

            var dismissUser = _applicationUserService.DismissUser(id);

            return Ok(dismissUser);
        }


    }
}
