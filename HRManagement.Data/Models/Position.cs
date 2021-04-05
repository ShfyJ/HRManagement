using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class Position //Xodim Lavozimi: Ex: Rais, Rahbar, Dep boshlig'i, yetakchi, ...
    {
        [Key]
        public int PositionId { get; set; }
        public string PositionTypeInKrillUz { get; set; }
        public string PositionTypeInLatinUz { get; set; }
        public string PositionTypeInRu { get; set; }
        public string PositionTypeInEng { get; set; }
        public bool Status { get; set; }
        public int SequenceNumber { get; set; } //Lavozim tartib raqami
        public int PositionDegreeId { get; set; }

        
        [ForeignKey("PositionDegreeId")]
        public PositionDegree PositionDegree { get; set; }


        
    }
}
