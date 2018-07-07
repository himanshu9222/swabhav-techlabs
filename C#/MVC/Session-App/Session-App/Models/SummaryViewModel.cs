using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session_App.Models
{
    public class SummaryViewModel
    {

        private int sessionValue;
        private int applicationValue;


       

        public int ApplicationValue
        {
            get
            {
                return applicationValue;
            }

            set
            {
                applicationValue = value;
            }
        }

        public int SessionValue
        {
            get
            {
                return sessionValue;
            }

            set
            {
                sessionValue = value;
            }
        }
    }
}