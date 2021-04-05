using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class Disability
    {
      
        [Required]
        public int DisabilityId { get; set; }
        public string DisabilityName { get; set; }
        public bool Status { get; set; }

    }
}