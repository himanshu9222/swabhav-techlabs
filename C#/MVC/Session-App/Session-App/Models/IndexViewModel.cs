using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session_App.Models
{
    public class IndexViewModel
    {
        private int _oldCount ;
        private int _newCount;
        private string _sessionId;

        public int OldCount
        {
            get { return _oldCount; }
            set { _oldCount = value;}
        }

        public int NewCount
        {
            get { return _newCount;}
            set { _newCount = value; }
        }

        public string SessionId
        {
            get
            {
                return _sessionId;
            }

            set
            {
                _sessionId = value;
            }
        }
    }
}