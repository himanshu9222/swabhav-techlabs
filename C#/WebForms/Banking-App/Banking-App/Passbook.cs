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
using System.IO;

namespace Banking_App
{
    public partial class Passbook : Form
    {
        MainForm mainForm;
        List<TransactionDataService> list;
        string textWrite="";
        public Passbook(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void Passbook_Load(object sender, EventArgs e)
        {
            GetData();
            nameLabel.Text = "NAME : " + mainForm.UserName.ToUpper();

        }

        public void GetData()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["server"].ToString());
            SqlCommand command;
            SqlDataReader reader;

            list = new List<TransactionDataService>();
            conn.Open();
            command = new SqlCommand { CommandText = "SELECT * FROM BANK_TRANSACTION WHERE NAME = @name", Connection = conn };
            command.Parameters.AddWithValue("@name", mainForm.UserName);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                TransactionDataService tds = new TransactionDataService();
                tds.Name = reader["NAME"].ToString();
                tds.Amount = int.Parse(reader["AMOUNT"].ToString());
                tds.TransactionType = reader["TTYPE"].ToString();
                tds.Date = reader["TTIME"].ToString();
                list.Add(tds);
                textWrite += tds.ToString();
            }
            dataGridView1.DataSource = list;
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {

            Button MyBtn = (Button)sender;

            switch (MyBtn.Name)
            {

                case "transactionBtn":
                    this.Close();
                    break;
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter("TransactionFileForUser"+mainForm.UserName+".txt");
            writer.WriteLine(textWrite);
            writer.Close();
            MessageBox.Show("SuccessFully Exported");
        }
    }
}
