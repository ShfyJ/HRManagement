using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class Department //Departament, Mustaqil bo'linma, lab, vhk (Korxonadan keyingi urovendagi)
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool IsDepartment { get; set; }
        public bool IsIndependentSection { get; set; }
        public int OrganizationId { get; set; }
        public bool Status { get; set; }

        [ForeignKey("OrganizationId")]
        public Organization Organization { get; set; }

        public ICollection<Section>? Sections { get; set; }
        public ICollection<Group>? Groups { get; set; }
    }
}