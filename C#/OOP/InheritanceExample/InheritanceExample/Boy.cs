using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceExample
{
    class Boy : Man
    {
        public void walk() {
		Console.WriteLine("Boy is Walking");
	}

	
	public override void play() {
		Console.WriteLine("Boy is playing");
	}

	public Boy() {
		Console.WriteLine("Boy created");
	}
    }
}
