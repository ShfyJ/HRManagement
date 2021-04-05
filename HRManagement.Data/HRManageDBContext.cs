
using HRManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Data
{
    public class HRManageDBContext : IdentityDbContext
    {
        public HRManageDBContext(DbContextOptions<HRManageDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Users> User { get; set; }
        public virtual DbSet<BusinessTrip> BusinessTrips { get; set; }
        public virtual DbSet<EmployeeVacation> EmployeeVacations { get; set; }
        public virtual DbSet<EmployeeDisciplinaryAction> EmployeeDisciplinaryActions { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<IndependentSection> IndependentSections { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Disability> Disabilities { get; set; }
        public virtual DbSet<DisciplinaryActionType> DisciplinaryActionTypes { get; set; }
        public virtual DbSet<EdInformation> EdInformations { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<MilitaryServiceStatus> MilitaryServiceStatuses { get; set; }
        public virtual DbSet<MilitaryTitle> MilitaryTitles { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<Partisanship> Partisanships { get; set; }
        public virtual DbSet<Passport> Passports { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<PositionDegree> PositionDegrees { get; set; }
        public virtual DbSet<Relative> Relatives { get; set; }
        public virtual DbSet<RelativeWorkingStatus> RelativeWorkingStatuses { get; set; }
        public virtual DbSet<ScienceDegree> ScienceDegrees { get; set; }
        public virtual DbSet<UserRelative> UserRelatives { get; set; }
        public virtual DbSet<Vacancy> Vacancies { get; set; }
        public virtual DbSet<VacationType> VacationTypes { get; set; }
        public virtual DbSet<WorkingActivity> WorkingActivities { get; set; }

    }

}
