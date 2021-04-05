using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
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
        public ICollection<Education> Educations { get; set; }
        public ICollection<WorkingActivity> WorkingActivities{ get; set; }
        public string? FullAddress { get; set; } //Agar Uz dan boshqa mamlakatdan bo'lsa, to'liq tug'ilgan joyi kiritiladi

        public int? PassportId { get; set; }
        public int? CountryId { get; set; }
        public int? DistrictId { get; set; }
        public int? NationalityId { get; set; }
        public int? PartisanshipId { get; set; }
        public int? ScienceDegreeId { get; set; }
        public int? EdInformationId { get; set; }
        public int? MilitaryServiceStatusId { get; set; }
        public int? MilitaryTitleId { get; set; }
        public int? DisabilityId { get; set; }
        public int? SectionId { get; set; } //bo'lim Id 
        public int? IndependentSectionId { get; set; }
        public int? GroupId { get; set; }
        public int? PositionId { get; set; } //Lavozim Id
        

        [ForeignKey("PositionId")]
        public Position Position { get; set; }


        [ForeignKey("SectionId")]
        public Section Section { get; set; }

        [ForeignKey("IndependentSectionId")]
        public IndependentSection IndependentSection { get; set; }

        [ForeignKey("GroupId")]
        public Group Group { get; set; }

        [ForeignKey("PassportId")]
        public Passport Passport { get; set; }

        [ForeignKey("CountryId")]
        public Country BirthCountry { get; set; }
        
        [ForeignKey("DistrictId")]
        public District BirthDistrict { get; set; }
        
        [ForeignKey("NationalityId")]
        public Nationality Nationality { get; set; }
        
        [ForeignKey("PartisanshipId")]
        public Partisanship Partisanship { get; set; }

        //ilmiy darajasi        
        [ForeignKey("ScienceDegreeId")]
        public ScienceDegree ScienceDegree { get; set; }

        //ma'lumoti (oliy, o'rta, ..)
        [ForeignKey("EdInformationId")]
        public EdInformation EdInformation { get; set; }
        //harbiy xizmat o'taganligi
        
        [ForeignKey("MilitaryServiceStatusId")]
        public MilitaryServiceStatus MilitaryServiceStatus { get; set; }

        //harbiy unvon
        [ForeignKey("MilitaryTitleId")]
        public MilitaryTitle MilitaryTitle { get; set; }
        
        [ForeignKey("DisabilityId")]
        public Disability Disability { get; set; }

        [NotMapped]
        public string Role { get; set; }



    }
}
