using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cubeBtn_Click(object sender, EventArgs e)
        {
            double input = double.Parse(inputTextbox.Text);

            CalculateLib.Calculator calculator = new CalculateLib.Calculator();

            try
            {
                resultLabel.Text = "Resuly : " + calculator.CubeIsEven(input);
            }catch(Exception ex)
            {
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = ex.Message;
            }
        }
    }
}
