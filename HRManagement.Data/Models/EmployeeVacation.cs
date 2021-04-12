using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class EmployeeVacation
    {
        [Key]
        public int EmployeeVacationId { get; set; }
        public string VacationPeriod { get; set; } //qaysi mehnat yilida. ex: 2019-2020
        public DateTime VacationStartDate { get; set; }
        public DateTime VacationEndDate { get; set; }
        public string ApplicationUrl { get; set; } //Arizasi
        public string Comment { get; set; }
        public int VacationtypeId { get; set; }
        public string EmployeeId { get; set; }

        [ForeignKey("VacationtypeId")]
        public VacationType Vacationtype { get; set; }

        [ForeignKey("EmployeeId")]
        public Data.Models.Auth.ApplicationUser Employee { get; set; }
    }
}
