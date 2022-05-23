using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace StoneClinic.Models.DB
{
    public partial class Usr
    {
        [Required(ErrorMessage = "Username can't be Empty")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Special Characters Not Allowed")]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Enter the Password")]
        public string Password { get; set; }
    }
}
