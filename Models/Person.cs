using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; }


        [Required]
        public string LastName { get; set; }


        [Required]
        public int Age { get; set; }


        [Required]
        public string EmailAddress { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }


        [Required]
        public string Password { get; set; }


        [Required]
        public string Description { get; set; }

    }
}
