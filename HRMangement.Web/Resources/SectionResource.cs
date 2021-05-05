﻿using HRManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Web.Resources
{
    public class SectionResource
    {
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public DepartmentForSectionResource Department { get; set; }
        public bool Status { get; set; }
       // public ICollection<GroupResource>? Groups{ get; set; }
    }
}
