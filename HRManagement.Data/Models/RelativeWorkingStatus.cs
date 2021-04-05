using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class RelativeWorkingStatus  //hozirda ishlaydi, nafaqada, uy bekasi, talaba, ...
    {
        [Key]
        public int RelativeWorkingStatusId { get; set; }
        public string RelativeWorkingStatusName { get; set; }
        public bool Status { get; set; }
    }
}