using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HRManagement.Services.ApplicationUser
{
    public interface IApplicationUserService
    {
       
        Task<IEnumerable<Models.ApplicationUser>> GetAllUsersWithAllInfos();
        Task<Models.ApplicationUser> GetUserById(string id);
        Task<ServiceResponse<Models.ApplicationUser>> CreateUser(Models.ApplicationUser applicationUser);
        Task<ServiceResponse<Models.ApplicationUser>> UpdateUser(Models.ApplicationUser userToBeUpdated, Models.ApplicationUser applicationUser);
        Task<ServiceResponse<Models.ApplicationUser>> DismissUser(string id);


    }
}
