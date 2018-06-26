using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceExample
{
    class Infant : Man
    {
        public override void play()
        {
            Console.WriteLine("Infant is Playing");
        }
    }
}
