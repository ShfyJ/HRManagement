using HRManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Web.Resources
{
    public class DepartmentResource
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public Organization Organization { get; set; }
        public ICollection<SectionResource> SectionResources { get; set; }
    }
}
