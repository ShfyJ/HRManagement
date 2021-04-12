using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class EmployeeDisciplinaryAction
    {
        [Key]
        public int EmployeeDisciplinaryActionId { get; set; }
        public DateTime OrderDateForAction { get; set; } //intizomiy jazoga buyruq sanasi
        public string OrderNumber { get; set; }
        public string OrderFileUrl { get; set; }
        public string ReasonForAction { get; set; } //qisqacha sababi
        public int DisciplinaryActionTypeId { get; set; }
        public string EmployeeId { get; set; }

        [ForeignKey("DisciplinaryActionTypeId")]
        public DisciplinaryActionType DisciplinaryActionType { get; set; }

        [ForeignKey("EmployeeId")]
        public Data.Models.Auth.ApplicationUser Employee { get; set; }
    }
}
