using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class VacationType
    {
        [Key]
        public int VacationtypeId { get; set; }
        public string VacationTypeName { get; set; }
        public bool Status { get; set; }
    }
}