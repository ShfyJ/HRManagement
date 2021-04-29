using HRManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Web.Resources
{
    public class EducationResource
    {
        public int EducationId { get; set; }
        public string EdOrganizationName { get; set; }
        public string Speciality { get; set; }
        public string? DiplomaUrl { get; set; }
        public string? EdOrgAddress { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime GraduatedDate { get; set; }
       
        public Data.Models.Auth.ApplicationUser User { get; set; }

        public ScienceDegree ScienceDegree { get; set; }

        public EdInformation EdInformation { get; set; }

        public Country EdOrgCountry { get; set; }
        public District EdOrgDistrict { get; set; }
    }
}
