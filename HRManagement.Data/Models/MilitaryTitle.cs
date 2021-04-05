using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    //harbiy unvon
    public class MilitaryTitle
    {
        [Key]
        public int MilitaryTitleId { get; set; }
        [Required]
        public string MilitaryTitleName { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}