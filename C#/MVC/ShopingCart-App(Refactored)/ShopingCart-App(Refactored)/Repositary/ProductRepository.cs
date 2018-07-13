using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ShopingCart_App_Refactored_.Models;

namespace ShopingCart_App_Refactored_.Repositary
{
    public class ProductRepository
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;
        public ProductRepository()
        {
            string connectionString = ConfigurationManager.AppSettings["server"].ToString();
            conn = new SqlConnection(connectionString);
        }


        public List<Product> FetchData()
        {
            List<Product> productList = new List<Product>();
            try
            {
                
                conn.Open();
                command = new SqlCommand("Select * from PRODUCT", conn);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.ProductName = reader["NAME"].ToString();
                        product.ProductPrice = double.Parse(reader["PRICE"].ToString());
                        productList.Add(product);
                    }

                }
                return productList;
            }
            catch (Exception ex)
            {
                return productList;
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