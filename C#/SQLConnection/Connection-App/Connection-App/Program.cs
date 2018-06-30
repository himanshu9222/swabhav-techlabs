using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Configuration.Assemblies;

namespace Connection_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"server=HP-PC\SQLEXPRESS;database=AurionPro;Integrated Security=True";
            //var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings[""].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionString);
            
            try
            {
                conn.Open();
                Console.WriteLine(conn.DataSource);
                

                SqlCommand fetch = new SqlCommand("Select * from DEPT",conn);
                SqlDataReader reader = fetch.ExecuteReader();


                while (reader.Read())
                {
                    Console.WriteLine(reader["DEPTNO"] + " " + reader["DNAME"] + " " + reader["LOC"]);
                }
                //if (reader.HasRows)
                //{
                //    while (reader.Read())
                //    {
                //        Console.WriteLine(reader["DEPTNO"] +" "+ reader["DNAME"]+" "+reader["LOC"]);
                //    }

                //}
                //else
                //{
                //    Console.WriteLine("No Data found");
                //}
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Console.WriteLine(conn.State);
            }
            Console.ReadKey();
        }
    }
}
