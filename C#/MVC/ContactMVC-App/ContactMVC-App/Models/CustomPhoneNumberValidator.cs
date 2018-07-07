using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ContactMVC_App.Models
{
    public class CustomPhoneNumberValidator : ValidationAttribute
    {
        public CustomPhoneNumberValidator() : base("Number is required")
        {

        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value.ToString()== null)
            {           
                var errormsg = FormatErrorMessage((validationContext.DisplayName));
                return new ValidationResult(errormsg);
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}