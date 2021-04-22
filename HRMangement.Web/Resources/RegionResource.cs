using HRManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Web.Resources
{
    public class RegionResource
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public bool Status { get; set; }
        public Country Country { get; set; }
    }
}
