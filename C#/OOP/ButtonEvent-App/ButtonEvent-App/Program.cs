using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ButtonEvent_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Button btn = new Button();
            btn.SetText("Hello");
            btn.OnClick += ButtonClickHandler;
            btn.Press();

            Button btn2 = new Button();
            btn2.SetText("Exit");
            btn2.OnClick += ButtonClickHandler;
            btn2.Press();
            Console.ReadKey();
        }

        static void ButtonClickHandler(Button x) { Console.WriteLine(x.GetText()); }
    }
}
