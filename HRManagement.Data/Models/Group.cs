using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int? SectionId { get; set; }
        public int? DepartmentId { get; set; } //Mustaqil bo'linma
        public bool Status { get; set; }

        [ForeignKey("SectionId")]
        public Section Section { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; } //Mustaqil bo'linma uchun
    }
}