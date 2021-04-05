using HRManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Services.ApplicationUser
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly HRManageDBContext _db;
       

        public ApplicationUserService(HRManageDBContext db)
        {
            _db = db;
            
        }

        /// <summary>
        /// Adds new user to database
        /// </summary>
        /// <param name="applicationUser"></param>
        /// <returns></returns>
        public async Task<ServiceResponse<Models.ApplicationUser>> CreateUser(Models.ApplicationUser applicationUser)
        {
            try
            {
               // await _userManager.CreateAsync(applicationUser);
                await _db.ApplicationUsers.AddAsync(applicationUser);
                await _db.SaveChangesAsync();

                return new ServiceResponse<Models.ApplicationUser>
                {
                    Data = applicationUser,
                    Time = DateTime.Now,
                    Message = "Yangi xodim qo'shildi",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.ApplicationUser>
                {
                    Data = applicationUser,
                    Time = DateTime.Now,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }

        }

        /// <summary>
        /// Dismis employee to dismissedusers table 
        /// </summary>
        /// <param name="applicationUser"></param>
        /// <returns></returns>
        public async Task<ServiceResponse<Models.ApplicationUser>> DismissUser(string id)
        {
            var applicationUser = _db.ApplicationUsers.Find(id);

            if(applicationUser == null)
            {
                return new ServiceResponse<Models.ApplicationUser>
                {
                    Time = DateTime.Now,
                    IsSuccess = false,
                    Message = "Foydalanuvchi topilmadi!",
                    Data = null
                };
            }

            try
            {
                applicationUser.IsDismissed = true;
                await _db.SaveChangesAsync();

                return new ServiceResponse<Models.ApplicationUser>
                {
                    Data = applicationUser,
                    Time = DateTime.Now,
                    Message = "Employee is dismissed",
                    IsSuccess = true
                };
            }
            catch(Exception e)
            {
                return new ServiceResponse<Models.ApplicationUser>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }


        /// <summary>
        /// Retrieves all users from database
        /// </summary>
        /// <returns>List<Users></returns>
        public async Task<IEnumerable<Models.ApplicationUser>> GetAllUsersWithAllInfos()
        {
            return await _db.ApplicationUsers
                .ToListAsync();
                    //.Include(user => user.BirthDistrict).ThenInclude(district => district.Region)
                    //.ThenInclude(region => region.Country).Include(user => user.BirthCountry)
                    //.Include(user => user.Section).ThenInclude(section => section.Department)
                    //.Include(user => user.Group).ThenInclude(group => group.Section).ThenInclude(section => section.Department)
                    //.Include(user => user.IndependentSection)
                    //.Include(user => user.MilitaryServiceStatus)
                    //.Include(user => user.MilitaryTitle)
                    //.Include(user => user.Nationality)
                    //.Include(user => user.Partisanship)
                    //.Include(user => user.Position)
                    //.Include(user => user.ScienceDegree)
                    //.OrderBy(user => user.Id)


        }

        /// <summary>
        /// Retrives one user from Database by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Models.ApplicationUser> GetUserById(string id)
        {
            //Need more values to add
            return await _db.ApplicationUsers
                .Include(user => user.Passport)
                //.Include(user => user.Educations)
                //.Include(user => user.WorkingActivities)
                //.Include(user => user.Passport)
                //.Include(user => user.BirthCountry)
                //.Include(user => user.BirthDistrict)
                //.ThenInclude(district => district.Region)
                .FirstOrDefaultAsync(user => user.Id == id);
        }


        public async Task<ServiceResponse<Models.ApplicationUser>> UpdateUser(Models.ApplicationUser userToBeUpdated, Models.ApplicationUser applicationUser)
        {

            if (userToBeUpdated == null)
            {
                return new ServiceResponse<Models.ApplicationUser>
                {
                    Time = DateTime.Now,
                    IsSuccess = false,
                    Message = "Foydalanuvchi topilmadi!",
                    Data = null
                };
            }

            try
            {
                userToBeUpdated.FirstName = applicationUser.FirstName;
                userToBeUpdated.LastName = applicationUser.LastName;
                //need more implementation
                await _db.SaveChangesAsync();

                return new ServiceResponse<Models.ApplicationUser>
                {
                    Data = userToBeUpdated,
                    Time = DateTime.Now,
                    Message = "Employee is dismissed",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.ApplicationUser>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }
    }
}
