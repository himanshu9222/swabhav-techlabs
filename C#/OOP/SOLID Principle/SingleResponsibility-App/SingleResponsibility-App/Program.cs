using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleResponsibility_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Himanshu", 1000, 10);
            invoice.calculateDiscount();
            invoice.calculateTax();
            InvoiceConsolePrint icp = new InvoiceConsolePrint();
            icp.printDetail(invoice);
            Console.ReadKey();
        }
    }
}
