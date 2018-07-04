using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Banking_App
{
    public partial class Register : Form
    {
        private MainForm mainform;
        public Register(MainForm form)
        {
            mainform = form;
            InitializeComponent();
            retypePasswordTextbox.UseSystemPasswordChar = true;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Button Mybtn = (Button)sender;

            switch (Mybtn.Name)
            {
                case "registerBtn":
                    if (RegisterDetails()) {
                        MessageBox.Show("Successfully Register");
                        this.Close();
                    }
                    break;
            }
        }

        public bool RegisterDetails()
        {

            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["server"].ToString());
                SqlCommand command;
                conn.Open();
                string name = nameTextbox.Text;
                string password = passwordTextbox.Text;
                string retypePassword = retypePasswordTextbox.Text;
                int balance = int.Parse(balanceTextbox.Text);

                command = new SqlCommand
                {
                    CommandText = "INSERT INTO BANK_MASTER(NAME,BALANCE,PASSWORD) VALUES(@name,@balance,@password)",
                    Connection = conn
                };
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@balance", balance);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
