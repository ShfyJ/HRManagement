using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Web.Resources
{
    public class SavePassportResource
    {
        public string PassportSeries { get; set; } //Passport seriasi

        public DateTime GivenDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string GivenBy { get; set; } //Kim tomonidan berilgan
    }

}
