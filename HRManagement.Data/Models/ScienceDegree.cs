using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class ScienceDegree
    { //Ilmiy daraja (dotsent,..)
        [Key]
        public int ScienceDegreeId { get; set; }
        [Required]
        public string ScienceDegreeName { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}