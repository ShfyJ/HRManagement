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
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using HRManagement.Constants;

namespace HRManagement.Services.ApplicationUser
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly HRManageDBContext _db;
        private readonly UserManager<Data.Models.Auth.ApplicationUser> _userManager;

        public ApplicationUserService(HRManageDBContext db, UserManager<Data.Models.Auth.ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;


        }

        /// <summary>
        /// Adds new user to database
        /// </summary>
        /// <param name="applicationUser"></param>
        /// <returns></returns>
        public async Task<ServiceResponse<IdentityResult>> SignUpUser(Data.Models.Auth.ApplicationUser userToCreate, string password)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(userToCreate.UserName);
                if(user == null)
                {
                    var userCreateResult = await _userManager.CreateAsync(userToCreate, password);
                    await _userManager.AddToRoleAsync(userToCreate, Roles.Basic.ToString());

                    //var newuser = await _userManager.FindByEmailAsync(userToCreate.UserName);
                    ////adding passport values to db and user
                    ////await _db.Passports.AddAsync(userToCreate.Passport);
                    ////var passport = await _db.Passports.FirstOrDefaultAsync(passport => passport.PassportSeries == userToCreate.Passport.PassportSeries);
                    ////newuser.PassportId = passport.PassportId;

                    ////adding education values to db and user
                    //foreach(var education in userToCreate.Educations)
                    //{
                    //    await _db.Educations.AddAsync(education);
                    //    education.EmployeeId = newuser.Id;
                    //}
                    
                    //await _db.SaveChangesAsync();

                    if (userCreateResult.Succeeded)
                    {
                        return new ServiceResponse<IdentityResult>
                        {
                            Data = userCreateResult,
                            Time = DateTime.Now,
                            Message = "Yangi xodim qo'shildi",
                            IsSuccess = true
                        };
                    }
                    return new ServiceResponse<IdentityResult>
                    {
                        Data = userCreateResult,
                        Time = DateTime.Now,
                        Message = "Yangi xodim qo'shilmadi",
                        IsSuccess = false
                    };
                }

                return new ServiceResponse<IdentityResult>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = "Bu login foydalanilgan",
                    IsSuccess = false
                };

            }
            catch (Exception e)
            {
                return new ServiceResponse<IdentityResult>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }



        }
        /// <summary>
        /// Sign In User
        /// </summary>
        /// <param name="applicationUser"></param>
        /// <returns></returns>
        public async Task<ServiceResponse<Data.Models.Auth.ApplicationUser>> SignInUser(string userName, string password)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.UserName == userName);


            if (user is null)
            {
                return new ServiceResponse<Data.Models.Auth.ApplicationUser>
                {
                    Time = DateTime.Now,
                    IsSuccess = false,
                    Message = "Foydalanuvchi topilmadi!",
                    Data = null
                };
            }

            try
            {
                var userSigninResult = await _userManager.CheckPasswordAsync(user, password);

                if (userSigninResult)
                {
                    var roles = await _userManager.GetRolesAsync(user);

                    return new ServiceResponse<Data.Models.Auth.ApplicationUser>
                    {
                        Time = DateTime.Now,
                        IsSuccess = true,
                        Message = "Foydalanuvchi va roli",
                        Items = roles,
                        Data = user
                    };
                    
                }
                else 
                    return new ServiceResponse<Data.Models.Auth.ApplicationUser>
                {
                    Time = DateTime.Now,
                    IsSuccess = true,
                    Message = "Email or password incorrect.",
                    Data = user
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Data.Models.Auth.ApplicationUser>
                {
                    Data = null,
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
        public async Task<ServiceResponse<Data.Models.Auth.ApplicationUser>> DismissUser(string id)
        {
            var applicationUser = _db.ApplicationUsers.Find(id);

            if(applicationUser == null)
            {
                return new ServiceResponse<Data.Models.Auth.ApplicationUser>
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

                return new ServiceResponse<Data.Models.Auth.ApplicationUser>
                {
                    Data = applicationUser,
                    Time = DateTime.Now,
                    Message = "Employee is dismissed",
                    IsSuccess = true
                };
            }
            catch(Exception e)
            {
                return new ServiceResponse<Data.Models.Auth.ApplicationUser>
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
        public async Task<IEnumerable<Data.Models.Auth.ApplicationUser>> GetAllUsersWithAllInfos()
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
        public async Task<Data.Models.Auth.ApplicationUser> GetUserById(string id)
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


        public async Task<ServiceResponse<Data.Models.Auth.ApplicationUser>> UpdateUser(Data.Models.Auth.ApplicationUser userToBeUpdated, Data.Models.Auth.ApplicationUser applicationUser)
        {

            if (userToBeUpdated == null)
            {
                return new ServiceResponse<Data.Models.Auth.ApplicationUser>
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

                return new ServiceResponse<Data.Models.Auth.ApplicationUser>
                {
                    Data = userToBeUpdated,
                    Time = DateTime.Now,
                    Message = "Employee is dismissed",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Data.Models.Auth.ApplicationUser>
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
