using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceExample
{
   class Man
    {
        public virtual void eat()
        {
            Console.WriteLine("Man is Eating");
        }

        public virtual void play()
        {
            Console.WriteLine("Man is Playing");
        }

        public virtual void read()
        {
            Console.WriteLine("Man is Reading");
        }
        public Man()
        {
            Console.WriteLine("Man created");
        }
    }
}
