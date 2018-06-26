using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection_App
{
    class LineItem_SortByPrice : IComparer<LineItem>
    {
        public int Compare(LineItem x, LineItem y)
        {
            if (x.getTotalPrice() < y.getTotalPrice()) return 1;
            else if (x.getTotalPrice() > y.getTotalPrice()) return -1;
            else return 0;
        }
    }
}
