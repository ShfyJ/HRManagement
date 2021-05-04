using HRManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Web.Resources
{
    public class ApplicationUserResource
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FIO_short { get; set; }
        public string FI_short { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        // public string PassportUrl { get; set; }
        public string PhotoUrl { get; set; }
        public string WorkbookURL { get; set; } //Mehnat daftarcha  
        //public int STIR { get; set; }         //INN
        public string STIRUrl { get; set; }
        public string OrderUrl { get; set; }  //Ishga olinishga buyruq
        public bool IsDismissed { get; set; } //Ishdan bo'shatilgan yoki yo'q
        public DateTime CreatedOn { get; set; } //Foydalanuvchini sistemaga kiritilgan vaqti
        public DateTime UpdatedOn { get; set; } //Foydalanuvchi shaxsiy malumotlari o'zgartirilgan vaqti
        public string FullAddress { get; set; } //Agar Uz dan boshqa mamlakatdan bo'lsa, to'liq tug'ilgan joyi kiritiladi
        public string FullBirthAddress { get; set; } //Agar Uz dan boshqa mamlakatdan bo'lsa, to'liq tug'ilgan joyi kiritiladi
        public string CurrentAddress { get; set; }

        public DateTimeOffset LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public ICollection<EducationResource> Educations { get; set; }
        public ICollection<WorkingActivity> WorkingActivities { get; set; }
        public ICollection<Language> Languages { get; set; }
        public ICollection<EmployeeDisciplinaryAction> DisciplinaryActions { get; set; }
        public ICollection<EmployeeVacation> Vacations { get; set; }
        public IList<UserBusinessTrips> UserBusinessTrips { get; set; }
        public PassportResource PassportResource { get; set; }
        public Country BirthCountry { get; set; }
        public Region BirthRegion { get; set; }
        public District BirthDistrict { get; set; }
        public Country CurrentCountry { get; set; }
        public Region CurrentRegion { get; set; }
        public District CurrentDistrict { get; set; }
        public Position Position { get; set; }
        public Section Section { get; set; }
        public Group Group { get; set; }
        public Nationality Nationality { get; set; }
        public Partisanship Partisanship { get; set; }
        public MilitaryServiceStatus MilitaryServiceStatus { get; set; }
        public MilitaryTitle MilitaryTitle { get; set; }
        public Disability Disability { get; set; }
        //Need more properties

    }
}
