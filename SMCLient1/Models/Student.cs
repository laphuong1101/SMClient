using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMCLient1.Models
{
    public class Student
    {
        public string StudentId { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDay { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string Desciption { get; set; }
    }
}