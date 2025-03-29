using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PitMan.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }

        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Course { get; set; }

    }
}