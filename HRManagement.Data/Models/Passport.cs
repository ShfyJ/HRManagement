using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class Passport
    {
        [Key]
        public int PassportId { get; set; }
        [Required]
        public string PassportSeries { get; set; } //Passport seriasi
        [Required]
        public DateTime GivenDate { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }
        [Required]
        public string GivenBy { get; set; } //Kim tomonidan berilgan
    }
    
}