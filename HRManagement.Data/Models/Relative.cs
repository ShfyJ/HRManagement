using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class Relative
    {
        [Key]
        public int RelativeId { get; set; }
        public string RelativeName { get; set; }
        public bool Status { get; set; }
    }
}
