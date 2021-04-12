using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HRManagement.Services.ApplicationUser
{
    public interface IApplicationUserService
    {
       
        Task<IEnumerable<Data.Models.Auth.ApplicationUser>> GetAllUsersWithAllInfos();
        Task<Data.Models.Auth.ApplicationUser> GetUserById(string id);
        Task<ServiceResponse<IdentityResult>> SignUpUser(Data.Models.Auth.ApplicationUser applicationUser, string password);
        Task<ServiceResponse<Data.Models.Auth.ApplicationUser>> SignInUser(string userName, string password);
        Task<ServiceResponse<Data.Models.Auth.ApplicationUser>> UpdateUser(Data.Models.Auth.ApplicationUser userToBeUpdated, Data.Models.Auth.ApplicationUser applicationUser);
        Task<ServiceResponse<Data.Models.Auth.ApplicationUser>> DismissUser(string id);


    }
}
