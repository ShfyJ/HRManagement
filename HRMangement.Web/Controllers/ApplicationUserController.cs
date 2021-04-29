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
using HRManagement.Data.Models.Auth;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using HRManagement.Web.Settings;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRMangement.Web.Controllers
{
   // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly ILogger<ApplicationUserController> _logger;
        private readonly IApplicationUserService _applicationUserService;
        private readonly IMapper _mapper;
        private readonly JwtSettings _jwtSettings;

        public ApplicationUserController(ILogger<ApplicationUserController> logger,
            IApplicationUserService applicationUserService, IMapper mapper, IOptionsSnapshot<JwtSettings> jwtSettings)
        {
            _logger = logger;
            _applicationUserService = applicationUserService;
            _mapper = mapper;
            _jwtSettings = jwtSettings.Value;
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


        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUpUser([FromBody] SaveApplicationUserResource saveApplicationUserResource)
        {
            _logger.LogInformation("Create a new user");

            var userToCreate = _mapper.Map<SaveApplicationUserResource, ApplicationUser>(saveApplicationUserResource);

            var serviceResponce = await _applicationUserService.SignUpUser(userToCreate, saveApplicationUserResource.Password);


            if (serviceResponce.IsSuccess)

            {
                return Created(string.Empty, string.Empty);
            }

            if(serviceResponce.Message.Equals("Bu login mavjud"))
            {
                return BadRequest("Bu login bilan foydalanuvchi bazada mavjud!");
            }

            return Problem(serviceResponce.Data.Errors.First().Description, null, 500);

            //var user = await _applicationUserService.GetUserById(userCreateResult.Data.Id);

            //var applicationUserResource = _mapper.Map<ApplicationUser, ApplicationUserResource>(user);

            //return Ok(applicationUserResource);

        }

        [AllowAnonymous]
        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(UserLoginResource userLoginResource)
        {
            
            var serviceResponce =  await _applicationUserService.SignInUser(userLoginResource.UserName, userLoginResource.Password);

            if (serviceResponce.Message.Equals("Foydalanuvchi topilmadi!"))
            {
                return NotFound("User not found");
            }

            if (serviceResponce.Message.Equals("Foydalanuvchi va roli"))
            {
                return Ok(GenerateJwt(serviceResponce.Data, serviceResponce.Items));
            }

            return BadRequest("Email or password incorrect.");
        }

        [HttpPatch("/api/applicationuser/{id}")]
        public async Task<ActionResult> DismissUser(string id)
        {
            _logger.LogInformation("Dismiss a user");

            await _applicationUserService.DismissUser(id);

            return Ok();
        }

        private string GenerateJwt(ApplicationUser user, IList<string> roles)
        {

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            var roleClaims = roles.Select(r => new Claim(ClaimTypes.Role, r));
            claims.AddRange(roleClaims);

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_jwtSettings.ExpirationInDays));

            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Issuer,
                claims,
                expires: expires,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }
}
