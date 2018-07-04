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
        MainForm mainForm;
        public LoginForm(MainForm form)
        {
            mainForm = form;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            passwordTextbox.UseSystemPasswordChar = true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Button MyBtn = (Button)sender;
            
            switch (MyBtn.Name)
            {
                case "loginBtn":
                    if (LoginValidation())
                    {   
                        mainForm.UserName = nameTextbox.Text;
                        MessageBox.Show("User "+ nameTextbox.Text + " Logged in Successfully");
                        mainForm.EnableButton(true);
                        mainForm.LoginRegisterButton(false);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password Id");
                    }
                    break;
            }
        }

        public bool LoginValidation()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["server"].ToString());
            SqlCommand command;
            
            conn.Open();
            string name = nameTextbox.Text;
            string password = passwordTextbox.Text;
            command = new SqlCommand { CommandText = "SELECT COUNT(*) FROM BANK_MASTER WHERE NAME = @name AND PASSWORD = @password", Connection = conn };
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@password", password);
            int count = Convert.ToInt32(command.ExecuteScalar());

            if(count == 1)
            {
                return true;
            }
            return false;
        }

    }
}
