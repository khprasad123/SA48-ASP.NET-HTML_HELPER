using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Html_Helper_Exercise.Models
{
    public class Registration
    {   
        [Required(ErrorMessage = "User Name is Required Field")]
        public string UserName { get; set; }

        [StringLength(15,MinimumLength=6,ErrorMessage = "Password should be min 6 and max 15 letters ")]
        [Required(ErrorMessage = "Password is Required Field")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="PassWord Must match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Pick a Gender ")]
        public string Gender { get; set; }

        [Display(Name ="Accept Terms And Conditions bro")]
        
        public bool Terms { get; set; }
    }
}