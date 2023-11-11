using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Student
    {
        [Required(ErrorMessage = "You must enter Student Id")]
        [DisplayName("Student Id")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter Student Name")]
        [DisplayName("Student Name")]
        public string Name { get; set; }

    }
}