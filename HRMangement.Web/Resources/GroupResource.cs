using HRManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HRManagement.Web.Resources
{
    public class GroupResource
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public SectionForGroupResource Section { get; set; }
        public DepartmentForSectionResource Department { get; set; }
        public bool Status { get; set; }
    }
}
