using HRManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Web.Resources
{
    public class DistrictResource
    {
        public int DisrictId { get; set; }
        public string DistrictName { get; set; }
        public bool Status { get; set; }
        public Region Region { get; set; }
    }
}
