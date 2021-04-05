using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class PositionDegree  //lavozim darajasi ex:AUP,UP,Texnik xodim, ishlab chiqarish, xizmat ko'ratish
    {
        [Key]
        public int PositionDegreeId { get; set; }
        public string PositionDegreeName { get; set; }
        public bool Status { get; set; }
    }
}