using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
//using System.Guid;

namespace Contact_App
{
    [Serializable]
    class Contact
    {
        private string _name;
        private string _number;
        private Guid _id;
        
        public string Name {
            set { _name = value; }
            get { return _name; }
        }

        public string Number {
            set { _number = value; }
            get { return _number; }
        }

        public void SetGuid() {
            _id = Guid.NewGuid();
        }

        public Guid GetGuid() {
            SetGuid();
            return _id;
        }

        public override string ToString()
        {
            return ("\nId= "+GetGuid()+"  Name= "+_name+"  Number= "+_number);
        }
        public bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^[6-9]\d{9}$").Success;
        }
    }
}
