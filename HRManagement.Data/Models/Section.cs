using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    //Bo'limlar, bo'linmalar, labaratoriya, vhk
    public class Section 
    {
        [Key]
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public int? DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

       


    }
}