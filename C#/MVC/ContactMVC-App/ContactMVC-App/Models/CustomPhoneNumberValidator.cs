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
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                
                if(Regex.IsMatch(value.ToString(), @"^[6-9]\d{9}$",RegexOptions.IgnorePatternWhitespace))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Please Enter a Valid Number.");
                }
            }
            else
            {
                return new ValidationResult("" + validationContext.DisplayName + " is required");
            }
        }
    }
}