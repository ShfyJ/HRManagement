using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Web.Resources
{
    public class SaveDepartmentResource
    {
        public string DepartmentName { get; set; }
        public int OrganizationId { get; set; }
        public bool IsDepartment { get; set; }
        public bool IsIndependentSection { get; set; }
        public bool Status { get; set; }
    }
}
