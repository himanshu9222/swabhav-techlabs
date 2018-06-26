using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection_App
{
    class Foo
    {   [ProTest]
        public bool M1()
        {
            return true;
        }

        [ProTest]
        public bool M2()
        {
            return false;
        }

        [ProTest]
        public bool M3()
        {
            return true;
        }

        public bool M4()
        {
            return false;
        }
    }
}
