using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contact_App.Components;
using Contact_App.DBConnection;


namespace Contact_App
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactConsole cc = new ContactConsole();
            cc.Menu();
        }
    }
}
