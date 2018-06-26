using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleWIN_App
{
    class WelcomeForm : Form
    {
       
        public WelcomeForm()
        {
            Button mybutton = new Button();
            mybutton.Visible = true;
            mybutton.Name = Name;
            mybutton.Text = "My Button";
            mybutton.Click += Handler;

            this.Controls.Add(mybutton);
        }

        public void Handler(object sender,EventArgs e) { Console.WriteLine("Button Clicked"); }
    }
}
