using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class Nationality
    {
        [Key]
        public int NationalityId { get; set; }
        [Required]
        public string NationalityName { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}