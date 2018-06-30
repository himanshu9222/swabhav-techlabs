using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WINForm_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Button myBtn = (Button)sender;

            switch (myBtn.Name)
            {
                case "btnHello":
                    MessageBox.Show("Hello");
                    break;
                case "btnExit":
                    MessageBox.Show("Exit");
                    break;
                default:
                    break;
            }
        }
    }
}
