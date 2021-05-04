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
        public Section Section { get; set; }
        public bool Status { get; set; }
    }
}
