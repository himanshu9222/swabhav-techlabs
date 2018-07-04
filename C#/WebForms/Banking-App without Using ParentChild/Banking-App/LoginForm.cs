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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Button MyBtn = (Button)sender;

            switch (MyBtn.Name)
            {
                case "loginBtn":
                    if (LoginValidation())
                    {
                        this.Hide();
                        Passbook passbook = new Passbook();
                        passbook.UserName = nameTextbox.Text;
                        passbook.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password Id");
                    }
                    break;

                case "registerBtn":
                    this.Hide();
                    Register register = new Register();
                    register.Show();
                    break;
            }
        }

        public bool LoginValidation()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["server"].ToString());
            SqlCommand command;
            SqlDataReader reader;
            conn.Open();
            string name = nameTextbox.Text;
            string password = passwordTextbox.Text;
            command = new SqlCommand { CommandText = "SELECT * FROM BANK_MASTER WHERE NAME = @name AND PASSWORD = @password", Connection = conn };
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@password", password);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                return true;
            }

            return false;
        }
    }
}
