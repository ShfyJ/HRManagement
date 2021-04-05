using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    //Harbiy xizmatni o'taganlik statusi
    public class MilitaryServiceStatus
    {
        [Key]
        public int MilitaryServiceStatusId { get; set; }
        [Required]
        public string MilitaryServiceStatusName { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}