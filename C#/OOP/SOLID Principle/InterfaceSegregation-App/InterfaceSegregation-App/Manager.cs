using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregation_App
{
    class Manager : IWorkableEatable
    {
        public void StartEating()
        {
            Console.WriteLine("Manager Start Eating");
        }

        public void StopEating()
        {
            Console.WriteLine("Manager Stop Eating");
        }

        public void StartWorking()
        {
            Console.WriteLine("Manager Start Working");
        }

        public void StopWorking()
        {
            Console.WriteLine("Manager Stop Working");
        }
    }
}
