using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class Vacancy
    {
        [Key]
        public int VacancyId { get; set; }
        public int PositionId { get; set; }
        public int? IndependentSectionId { get; set; }
        public int? GroupId { get; set; }

        [ForeignKey("PositionId")]
        public Position Position { get; set; }

        [ForeignKey("GroupId")]
        public Group Group { get; set; }
    }
}
