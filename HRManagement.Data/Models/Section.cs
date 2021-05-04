using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    //Bo'limlar, mustaqil bo'linmalar, labaratoriya, vhk
    public class Section 
    {
        [Key]
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public int? DepartmentId { get; set; }
        public int? OrganizationId { get; set; }
        public bool Status { get; set; }
        public bool IsIndependentSection { get; set; }
        public bool IsDepartmentSection { get; set; }

        [ForeignKey("OrganizationId")]
        public Organization Organization { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public ICollection<Group>? Groups { get; set; }

       


    }
}