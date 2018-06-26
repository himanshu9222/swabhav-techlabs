using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection_App
{
    class Xml : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
