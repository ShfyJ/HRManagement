using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    //Partivayligi
    public class Partisanship
    {
        [Key]
        public int PartisanshipId { get; set; }
        [Required]
        public string PartisanshipName { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}