using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Web.Resources
{
    public class SaveEducationResource
    {
        public string EdOrganizationName { get; set; }
        public string Speciality { get; set; }
        public string? DiplomaUrl { get; set; }
        public string? EdOrgAddress { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime GraduatedDate { get; set; }
        public int? ScienceDegreeId { get; set; }
        public int? EdInformationId { get; set; }
        public int? EdOrgCountryId { get; set; }

        public int? EdOrgDistrictId { get; set; }
        public string EmployeeId { get; set; }
    }
}
