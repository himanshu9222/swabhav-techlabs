using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace SimpleTransaction_App
{
    
    class Transaction
    {
        SqlConnection conn;
        SqlCommand command1, command2,command3,command4;
        SqlTransaction transaction;
        SqlDataReader reader;

        public Transaction()
        {
            string connectionString = ConfigurationManager.AppSettings["server"].ToString();
            conn = new SqlConnection(connectionString);
            Console.WriteLine(conn.Database);
        }

        public void CustomerPay(int amt)
        {
            
            //int newvalue = 0; 
            try
            {
                //conn.Open();
                //command3 = new SqlCommand {CommandText = "SELECT BALANCE FROM MERCHANT WHERE NAME = 'DEALER'",Connection = conn };
                ////command1 = new SqlCommand { CommandText = "UPDATE CUSTOMER SET BALANCE =", Connection = conn }; 
                ////command1.Parameters.AddWithValue("@nameNewValue", newvalue);
                ////reader = fetch.ExecuteReader();
                //reader = command3.ExecuteReader();
                //Console.WriteLine(reader);
                //Console.WriteLine(int.Parse(reader.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            finally
            {
                Close();
            }
        }
        public void Close()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
