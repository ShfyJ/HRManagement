using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    //Ta'limi; qaysi universitet, kolledj, institutda o'qiganligi..
    public class Education
    {
        [Key]
        public int EducationId { get; set; }
        public string EdOrganizationName { get; set; }
        public string Speciality { get; set; }
        public string? DiplomaUrl { get; set; }
        public string? EdOrgAddress { get; set; }
        public DateTime? EnteredDate { get; set; }
        public DateTime? GraduatedDate { get; set; }
        public int? ScienceDegreeId { get; set; }
        public int? EdInformationId { get; set; }
        public int? EdOrgCountryId { get; set; }
        
        public int? EdOrgDistrictId { get; set; }
        public string EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Data.Models.Auth.ApplicationUser User { get; set; }

        [ForeignKey("ScienceDegreeId")]
        public ScienceDegree ScienceDegree { get; set; }

        [ForeignKey("EdInformationId")]
        public EdInformation EdInformation { get; set; }

        [ForeignKey("CountryId")]
        public Country EdOrgCountry { get; set; }

        [ForeignKey("DistrictId")]
        public District EdOrgDistrict { get; set; }


    }
}