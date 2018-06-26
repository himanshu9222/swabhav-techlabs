using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Employee_max_Salary_App
{
    class WebLoader : ILoadable
    {
        string text;
        public string LoadFile()
        {
            WebClient wc = new WebClient();
            try
            {
                string result = wc.DownloadString("https://swabhav-tech.firebaseapp.com/emp.txt");
                Console.WriteLine(result);
            }
            catch (WebException we) { Console.WriteLine(we.ToString()); }
            
            return text;
        }
    }
}
