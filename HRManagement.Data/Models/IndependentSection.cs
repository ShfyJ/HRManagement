using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{   //Mustaqil bo'linmalar, labaratoriya, vhk...
    public class IndependentSection
    {
        [Key]
        public int IndependentSectionId { get; set; }
        public string IndependentSectionName { get; set; }
        public int? OrganizationId { get; set; }

        [ForeignKey("OrganizationId")]
        public Organization Organization { get; set; }
    }
}