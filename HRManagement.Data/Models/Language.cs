using HRManagement.Data.Models.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }
        [Required]
        public string LanguageName { get; set; }
        [Required]
        public bool Status { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
