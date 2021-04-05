using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace HRManagement.Models
{
    public class DisciplinaryActionType
    {
        [Key]
        public int DisciplinaryActionTypeId { get; set; }
        public string DisciplinaryActionName { get; set; }
        public bool Status { get; set; }
    }
}