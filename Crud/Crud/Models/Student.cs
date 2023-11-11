using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace Crud.Models
{
    public class Student
    {
        [Key, Column("StudentId", Order = 0)]
        [Required(ErrorMessage = "You must enter Student Id")]
        [DisplayName("Student Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Student Name")]
        [DisplayName("Student Name")]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        public string Email { get; set; }
        public string Password { get; set; }
        public Grade GradeId { get; set; }
    }
}