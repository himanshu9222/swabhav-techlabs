using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Contact_App.Components;
using System.Configuration;

namespace Contact_App.DBConnection
{
    class ContactDB
    {
        SqlConnection conn;
        SqlCommand fetch = null;
        SqlDataReader reader = null;
        public ContactDB()
        {
            //@ is used to skip special character such as \
            string connectionString = ConfigurationManager.AppSettings["server"].ToString();
            conn = new SqlConnection(connectionString);
            Console.WriteLine(conn.Database);
        }

        public void Insert(Contact contact)
        {
            Guid uuid = contact.GetGuid(); ;
            string name = contact.Name;
            string number = contact.Number.ToString();
            string insertString = "INSERT INTO CONTACT(ID,NAME,NUMBER) VALUES (@idvalue,@namevalue,@numbervalue );";
            try
            {
                conn.Open();
                fetch = new SqlCommand { CommandText = insertString, Connection = conn };
                fetch.Parameters.AddWithValue("@idvalue", uuid);
                fetch.Parameters.AddWithValue("@namevalue", name);
                fetch.Parameters.AddWithValue("@numbervalue", number);
                fetch.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public void Update(string name)
        {

            try
            {
                conn.Open();
                Console.WriteLine("Enter Name to be Updated");
                string newName = Console.ReadLine();
                Console.WriteLine("Enter Number to be Updated");
                string number = Console.ReadLine();
                fetch = new SqlCommand { CommandText = "UPDATE CONTACT SET NAME = @nameNewValue , NUMBER = @numbervalue WHERE NAME = @namevalue", Connection = conn };
                fetch.Parameters.AddWithValue("@namevalue", name);
                fetch.Parameters.AddWithValue("@nameNewValue", newName);
                fetch.Parameters.AddWithValue("@numbervalue", number);
                reader = fetch.ExecuteReader();
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

        public void Delete(string name)
        {
            try
            {
                conn.Open();
                fetch = new SqlCommand { CommandText = "DELETE FROM CONTACT WHERE NAME= @namevalue", Connection = conn };
                fetch.Parameters.AddWithValue("@namevalue", name);
                reader = fetch.ExecuteReader();
                

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

        public void SearchByName(string name)
        {
            try
            {
                conn.Open();
                fetch = new SqlCommand { CommandText = "Select * from CONTACT WHERE NAME = @namevalue", Connection = conn };
                fetch.Parameters.AddWithValue("@namevalue", name);
                reader = fetch.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["ID"] + " " + reader["NAME"] + " " + reader["NUMBER"]);
                    }

                }
                else
                {
                    Console.WriteLine("No Data found");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Close();
            }
            
        }

        public void Display()
        {
            try
            {
                conn.Open();
                fetch = new SqlCommand("Select * from CONTACT", conn);
                reader = fetch.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["ID"] + " " + reader["NAME"] + " " + reader["NUMBER"]);
                    }

                }
                else
                {
                    Console.WriteLine("No Data found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Close();
            }
            
        }

        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
