using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceExample
{
    class Kid : Man
    {
        public override void play()
        {
            Console.WriteLine("Kid is playing");
        }
    }
}
