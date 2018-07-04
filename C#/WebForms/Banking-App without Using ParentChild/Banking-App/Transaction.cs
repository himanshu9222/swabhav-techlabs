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
    public partial class Transaction : Form
    {
        private string name;
        public Transaction()
        {
            InitializeComponent();
        }

        public string UserName
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            nameLabel.Text = "Name : " + name;
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            Button MyBtn = (Button)sender;
            switch (MyBtn.Name)
            {

                case "transactionBtn":
                    DoTransaction();
                    this.Hide();
                    Passbook passbook = new Passbook();
                    passbook.UserName = name;
                    passbook.Show();
                    break;
            }
        }

        public void DoTransaction()
        {
            int amount = int.Parse(amountTextbox.Text);
            string ttype = null;
            if (depositRadioBtn.Checked== true) { ttype = "D"; }
            else if (withdrawRadioBtn.Checked == true) { ttype = "W"; }
            else { MessageBox.Show("Please Select Transaction Type"); }

            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["server"].ToString());
            SqlCommand command;

            conn.Open();
            command = new SqlCommand { CommandText = "INSERT INTO BANK_TRANSACTION(NAME,AMOUNT,TTYPE,TTIME) VALUES (@name,@amount,@ttype ,GETDATE())", Connection = conn };
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("amount",amount);
            command.Parameters.AddWithValue("@ttype", ttype);

            command.ExecuteNonQuery();
            
        }

    }
}
