using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregation_App
{
    class Robot : IWorkable
    {
        public void StartWorking()
        {
            Console.WriteLine("Robot Start Working");
        }

        public void StopWorking()
        {
            Console.WriteLine("Robot Stop Working");
        }
    }
}
