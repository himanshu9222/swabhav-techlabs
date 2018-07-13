using ShopingCart_App_Refactored_.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ShopingCart_App_Refactored_.Repositary
{
    public class OrderRepository
    {

        SqlConnection conn;
        SqlCommand command1, command2;
        SqlTransaction transaction;
        public OrderRepository()
        {
            string connectionString = ConfigurationManager.AppSettings["server"].ToString();
            conn = new SqlConnection(connectionString);
        }

        public void Save(Order order)
        {

            string insertStringForOrder
                = "INSERT INTO ORDERS(ORDERID,ORDERDATE,CHECKOUTPRICE) VALUES (@orderid,@datevalue,@checkoutprice);";
            string insertStringForLineItem
                = "INSERT INTO LINEITEMS(ORDERID,NAME,PRICE,QUANTITY,TOTAL) VALUES (@orderid,@name,@price,@quantity,@total );";
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command1 = new SqlCommand { CommandText = insertStringForOrder, Connection = conn };
                command1.Parameters.AddWithValue("@orderid", order.OrderId);
                command1.Parameters.AddWithValue("@datevalue", order.OrderDate);
                command1.Parameters.AddWithValue("@checkoutprice", order.CheckOutPrice);
                command1.Transaction = transaction;
                command1.ExecuteNonQuery();

                foreach (LineItem lineitem in order.LineItemsList)
                {
                    command2 = new SqlCommand { CommandText = insertStringForLineItem, Connection = conn };
                    command2.Parameters.AddWithValue("@orderid", order.OrderId);
                    command2.Parameters.AddWithValue("@name", lineitem.Product.ProductName);
                    command2.Parameters.AddWithValue("@price", float.Parse(lineitem.Product.ProductPrice.ToString()));
                    command2.Parameters.AddWithValue("@quantity", lineitem.Quantity);
                    command2.Parameters.AddWithValue("@total", lineitem.GetLineItemCost);
                    command2.Transaction = transaction;
                    command2.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
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