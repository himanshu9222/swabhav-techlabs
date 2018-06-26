using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection_App
{
    class LineItem_SortByName : IComparer<LineItem>
    {

        public int Compare(LineItem x, LineItem y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
