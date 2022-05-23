using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace StoneClinic.Models.DB
{
    public partial class Patient
    {
        public Patient()
        {
            Appointments = new HashSet<Appointment>();
        }
        [Key]
        public int PatientId { get; set; }
        [Required(ErrorMessage = "Please Enter The First Name")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Special Characters Not Allowed")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter The Last Name")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Special Characters Not Allowed")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Choose Gender")]
        public string Sex { get; set; }

        public int? Age { get; set; }
        [Required(ErrorMessage = "Please Enter The Date of Birth")]
        public string Dob { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
