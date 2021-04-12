using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class WorkingActivity //mehnat faoliyati
    {
        [Key]
        public int WorkingActivityId { get; set; }
        public string OrganizationName { get; set; }
        public string PositionName { get; set; }
        public string PositionNameInFull { get; set; }
        public string PositionType { get; set; } //O'sha tashkilotdagi lavozim turi
        public bool IsNetworkExperience { get; set; } //tarmoq stajiga kiradi/kirmaydi
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Data.Models.Auth.ApplicationUser User { get; set; }
    }
}
