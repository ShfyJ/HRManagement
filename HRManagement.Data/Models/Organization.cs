using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class Organization
    {
        [Key]
        public int OrganizationId { get; set; }
        public string OrganizationNameInKrillUz { get; set; }
        public string OrganizationNameInLatinUz { get; set; }
        public string OrganizationNameInRu { get; set; }
        public string OrganizationNameInEng { get; set; }
        public string OrganizationNameInKrillUzShort { get; set; }
        public string OrganizationNameInLatinUzShort { get; set; }
        public string OrganizationNameInRuShort { get; set; }
        public string OrganizationNameInEngShort { get; set; }
        public bool Status { get; set; }

    }
}