using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    //Bo'limlar Departamentga qarashli
    public class Section 
    {
        [Key]
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public int? DepartmentId { get; set; }
        public bool Status { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public ICollection<Group>? Groups { get; set; }

       


    }
}