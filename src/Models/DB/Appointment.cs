using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace StoneClinic.Models.DB
{
    public partial class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        [Required(ErrorMessage = "Please Enter The Patient ID")]
        public int? PatientId { get; set; }
        [Required(ErrorMessage = "Please Choose The Specialization")]
        public string Specialization { get; set; }
        [Required(ErrorMessage = "Please Choose Doctor")]
        public string Doctor { get; set; }
        [Required(ErrorMessage = "Please Choose Visiting Date")]
        public string VisitDate { get; set; }
        [Required(ErrorMessage = "Please Choose Appointment Time")]
        public string AppointmentTime { get; set; }
        [Display(Name = "Doctor")]
        public virtual Doctor DoctorNavigation { get; set; }
        [Display(Name = "Patient Id")]
        public virtual Patient Patient { get; set; }
    }
}
