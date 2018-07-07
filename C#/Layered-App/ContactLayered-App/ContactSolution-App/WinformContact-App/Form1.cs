using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactCore.Components;
using ContactCore.Exceptions;

namespace WinformContact_App
{
    public partial class Form1 : Form
    {
        ContactStore cs = new ContactStore();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Button myBtn = (Button)sender;
            switch (myBtn.Name)
            {
                case "button1":
                    UpdateGrid();                                      
                    break;

                case "button2":
                    string name = textBox1.Text;
                    string number = textBox2.Text;
                    Contact addContact = new Contact();
                    addContact.Name = name;
                    addContact.Number = number;
                    addContact.GetGuid();
                    cs.Add(addContact);
                    cs.Serialize();
                    UpdateGrid();
                    break;
            }

        }

        public void UpdateGrid()
        {
            dataGridView1.DataSource = cs.ContactList;
        }


    }
}
