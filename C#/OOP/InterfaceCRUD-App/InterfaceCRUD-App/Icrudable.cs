using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceCRUD_App
{
    interface Icrudable
    {
        void create();

        void read();

        void update();

        void delete();

    }
}
