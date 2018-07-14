using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactMVC_With_EF.Models
{
    public class Contact
    {
        
        private string name;
        private string number;

        [Key]
        [Required(ErrorMessage = "Name is Required")]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        [Required(ErrorMessage = "Number is Required")]
        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Wrong Number Format")]
        public string Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }
    }
}