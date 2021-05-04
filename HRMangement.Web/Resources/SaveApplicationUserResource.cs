using HRManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Web.Resources
{
    public class SaveApplicationUserResource
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FIO_short { get; set; }
        public string FI_short { get; set; }
        public string Gender { get; set; }
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
        public string FullBirthAddress { get; set; } //Agar Uz dan boshqa mamlakatdan bo'lsa, to'liq tug'ilgan joyi kiritiladi
        public string CurrentAddress { get; set; }
        public DateTimeOffset LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }

        //public ICollection<Education> Educations { get; set; }
        public SavePassportResource Passport { get; set; }
        public ICollection<SaveEducationResource> Educations { get; set; }
        public int? BirthCountryId { get; set; }
        public int? BirthRegionId { get; set; }
        public int? BirthDistrictId { get; set; }
        public int? CurrentCountryId { get; set; }
        public int? CurrentRegionId { get; set; }
        public int? CurrentDistrictId { get; set; }
        public int? NationalityId { get; set; }
        public int? PartisanshipId { get; set; }
        //public int? ScienceDegreeId { get; set; }
        //public int? EdInformationId { get; set; }
        public int? MilitaryServiceStatusId { get; set; }
        public int? MilitaryTitleId { get; set; }
        public int? DisabilityId { get; set; }
        //public int? SectionId { get; set; } //bo'lim Id 
        //public int? IndependentSectionId { get; set; }
        //public int? GroupId { get; set; }
        //public int? PositionId { get; set; } //Lavozim Id

        //Need more properties

        public SaveApplicationUserResource()
        {
            EmailConfirmed = true;
            PhoneNumberConfirmed = true;
            IsDismissed = false;
        }
    }
}
