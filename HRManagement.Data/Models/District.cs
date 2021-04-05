using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class District
    {
        [Key]
        public int DisrictId { get; set; }
        [Required]
        public string DistrictName { get; set; }
        public bool Status { get; set; }

        public int RegionId { get; set; }
        public int CountryId { get; set; }

        [ForeignKey("RegionId")]
        public Region Region { get; set; }

        
    }
}