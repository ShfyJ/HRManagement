using HRManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class BusinessTrip
    {
        [Key]
        public int BusinessTripId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
        public string BusinessTripMission { get; set; }
        public string? BusinessTripAddress { get; set; }
        public string BusinessTripProgramFileUrl { get; set; }
        public string? Comment { get; set; }
        public int BusinessTripCountryId { get; set; }
        
        public int? BusinessTripDistrictId { get; set; }
        public IList<UserBusinessTrips> UserBusinessTrips { get; set; }

        [ForeignKey("BusinessTripCountryId")]
        public Country BusinessTripCountry { get; set; }

        [ForeignKey("BusinessTripDistrictId")]
        public District BusinessTripDistrict { get; set; }


    }
}
