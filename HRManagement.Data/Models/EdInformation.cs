using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    //Xodim ma'lumoti (oliy, o'rta, o'rta-maxsus ..)
    public class EdInformation
    {
        [Key]
        public int EdInformationId { get; set; }
        [Required]
        public string EdInformationName { get; set; }
        [Required]
        public bool Status { get; set; }

    }
}