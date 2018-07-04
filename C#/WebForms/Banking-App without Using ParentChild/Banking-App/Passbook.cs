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
    public partial class Passbook : Form
    {
        private string name;
        public Passbook()
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

        private void Passbook_Load(object sender, EventArgs e)
        {
            GetData();
            nameLabel.Text = "NAME : " + name.ToUpper();

        }

        public void GetData()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["server"].ToString());
            SqlCommand command;
            SqlDataReader reader;

            TransactionDataService tds = new TransactionDataService();
            var list = new List<TransactionDataService>();
            conn.Open();
            command = new SqlCommand { CommandText = "SELECT * FROM BANK_TRANSACTION WHERE NAME = @name", Connection = conn };
            command.Parameters.AddWithValue("@name", name);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                tds.Name = reader["NAME"].ToString();
                tds.Amount = int.Parse(reader["AMOUNT"].ToString());
                tds.TransactionType = reader["TTYPE"].ToString();
                tds.Date = reader["TTIME"].ToString();
                list.Add(tds);
            }
            dataGridView1.DataSource = list;
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {

            Button MyBtn = (Button)sender;

            switch (MyBtn.Name)
            {

                case "transactionBtn":
                    this.Hide();
                    Transaction transaction = new Transaction();
                    transaction.UserName = name.ToUpper();
                    transaction.Show();
                    break;
            }
        }
    }
}
