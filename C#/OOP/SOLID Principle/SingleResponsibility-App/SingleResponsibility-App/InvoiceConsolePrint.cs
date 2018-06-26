using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleResponsibility_App
{
    class InvoiceConsolePrint
    {
        public void printDetail(Invoice invoice){
		Console.WriteLine("Number =" + invoice.Number + "\tName = " + invoice.Name
				+ "\tTotal Cost =" + invoice.totalCost());
	}
    }
}
