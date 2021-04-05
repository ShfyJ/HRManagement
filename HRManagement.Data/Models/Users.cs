using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class Users
    {
        [Required]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FIO_short { get; set; }
        public string FI_short { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        // public string PassportUrl { get; set; }
        public string PhotoUrl { get; set; }
        public string WorkbookURL { get; set; } //Mehnat daftarcha  
        //public int STIR { get; set; }         //INN
        public string STIRUrl { get; set; }
        public string OrderUrl { get; set; }  //Ishga olinishga buyruq
        public bool IsDismissed { get; set; } //Ishdan bo'shatilgan yoki yo'q

    }
}
