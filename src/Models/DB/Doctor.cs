using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace StoneClinic.Models.DB
{
    public partial class Doctor
    {
        public Doctor()
        {
            Appointments = new HashSet<Appointment>();
        }
        [Key]
        public int DoctorId { get; set; }
        [Required(ErrorMessage = "Please Enter The First Name")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Special Characters Not Allowed")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter The Last Name")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Special Characters Not Allowed")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Choose Gender")]
        public string Sex { get; set; }
        [Required(ErrorMessage = "Please Choose The Specialization")]
        public string Specialization { get; set; }
        [Required(ErrorMessage = "Please Choose  The Visiting Hours")]
        public string VisitingHours { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
