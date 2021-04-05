using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class UserRelative
    {
        [Key]
        public int UserRelativesId { get; set; }
        public string UserRelativeFullName { get; set; }
        public DateTime UserRelativeBirthDate { get; set; }
        //public DateTime UserRelativeBirthDate { get; set; }
        public string? UserRelaivesBirthAddress { get; set; }
        public string? UserRelaivesLivingAddress { get; set; }
        public string? UserRelativesWorkingPlaceAndPosition { get; set; }
        public DateTime StartedWorkingDate { get; set; } //hozirgi ishida qachondan beri ishlayotgani
        public int RelativeId { get; set; }
        public int? BirthCountryId { get; set; }
        
        public int? BirthDistrictId { get; set; }
        public int? LivingCountryId { get; set; }
        
        public int? LivingDistrictId { get; set; }
        public int RelativeWorkingStatusId { get; set; } //ishlaydi, nafaqada, talaba ...
        public string? EmployeeId { get; set; }

        [ForeignKey("RelativeId")]
        public Relative Relative { get; set; }

        [ForeignKey("BirthCountryId")]
        public Country BirthCountry { get; set; }


        [ForeignKey("BirthDistrictId")]
        public District BirthDistrict { get; set; }

        [ForeignKey("LivingCountryId")]
        public Country LivingCountry { get; set; }


        [ForeignKey("LivingDistrictId")]
        public District LivingDistrict { get; set; }

        [ForeignKey("RelativeWorkingStatusId")]
        public RelativeWorkingStatus RelativeWorkingStatus { get; set; }

        [ForeignKey("EmployeeId")]
        public ApplicationUser Employee { get; set; }

    }
}
