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
        public bool Status { get; set; }
        public bool IsIndependentSection { get; set; }
        public int OrganizationId { get; set; }
        public OrganizationResource Organization { get; set; }
      //  public ICollection<Section> Sections { get; set; }
    }
}
