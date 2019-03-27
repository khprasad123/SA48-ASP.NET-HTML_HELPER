using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Html_Helper_Exercise.Models
{
    public class Registration
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string ConfirmPassword { get; set; }
        public string Gender { get; set; }
        public bool Terms { get; set; }
    }
}