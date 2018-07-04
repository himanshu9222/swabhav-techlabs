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
        SqlCommand command1, command2;
        SqlTransaction transaction;

        public Transaction()
        {
            string connectionString = ConfigurationManager.AppSettings["server"].ToString();
            conn = new SqlConnection(connectionString);
            Console.WriteLine(conn.Database);
        }

        public void CustomerPay(int amt)
        {
            
            int newvalue= amt; 
            try
            {
                conn.Open();
                string dealer = "DEALER";
                string customer = "HIMANSHU";
                command1 = new SqlCommand { CommandText = "UPDATE MERCHANT SET BALANCE = BALANCE + @mvalue WHERE NAME = @mname", Connection = conn }; 
                command1.Parameters.AddWithValue("@mname", dealer);
                command1.Parameters.AddWithValue("@mvalue",newvalue);
                command2 = new SqlCommand { CommandText = "UPDATE CUSTOMER SET BALANCE = BALANCE - @cvalue WHERE NAME = @name", Connection = conn };
                command2.Parameters.AddWithValue("@cname", customer);
                command2.Parameters.AddWithValue("@cvalue", newvalue);
                transaction = conn.BeginTransaction();
                command1.Transaction = transaction;
                command2.Transaction = transaction;
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                transaction.Commit();
                Console.WriteLine("Transaction Completed");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            finally
            {
                Close();
            }
        }

        public void DealerPay(int amt)
        {

            int newvalue = amt;
            try
            {
                conn.Open();
                string dealer = "DEALER";
                string customer = "HIMANSHU";
                command1 = new SqlCommand { CommandText = "UPDATE MERCHANT SET BALANCE = BALANCE - @mvalue WHERE NAME = @mname", Connection = conn };
                command1.Parameters.AddWithValue("@mname", dealer);
                command1.Parameters.AddWithValue("@mvalue", newvalue);
                command2 = new SqlCommand { CommandText = "UPDATE CUSTOMER SET BALANCE = BALANCE + @cvalue WHERE NAME = @cname", Connection = conn };
                command2.Parameters.AddWithValue("@cname", customer);
                command2.Parameters.AddWithValue("@cvalue", newvalue);
                transaction = conn.BeginTransaction();
                command1.Transaction = transaction;
                command2.Transaction = transaction;
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                transaction.Commit();
                Console.WriteLine("Transaction Completed");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
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
