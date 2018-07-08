using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ContactMVC_App.Models
{
    public class EditViewModel
    {
        private List<Contact> list;
        private string _name;
        private string _number;

        public List<Contact> List
        {
            get
            {
                return list;
            }

            set
            {
                list = value;
            }
        }

        [Required(ErrorMessage = "Name is Required")]
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        [Required(ErrorMessage = "Number is Required")]
        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Wrong Number Format")]
        public string Number
        {
            get
            {
                return _number;
            }

            set
            {
                _number = value;
            }
        }
    }
}