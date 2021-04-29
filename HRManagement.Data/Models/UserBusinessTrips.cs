using HRManagement.Data.Models.Auth;
using HRManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class UserBusinessTrips
    {
        public string EmployeeId { get; set; }
        public ApplicationUser Employee { get; set; }

        public int BusinessTripId { get; set; }
        public BusinessTrip BusinessTrip { get; set; }

        public bool IsSubstitute { get; set; }

    }
}
