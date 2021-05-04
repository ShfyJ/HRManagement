using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class DeputyMembership
    {
        [Key]
        public int DeputyMembershipId { get; set; }
        public string DeputyMembershipName { get; set; }
        public bool Status { get; set; }
    }
}
