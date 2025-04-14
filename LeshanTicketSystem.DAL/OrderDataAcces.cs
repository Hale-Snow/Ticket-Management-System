using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace LeshanTicketSystem.DAL
{
    public class OrderDataAcces
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString;

        public DataTable GetOrders()
        {
            DataTable ordersTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id,order_id, name,  sex ,phone,id_card,  price FROM orders";
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                    dataAdapter.Fill(ordersTable);
                }
                catch (Exception ex)
                {
                    // 这里抛出异常到 BLL 层
                    throw new ApplicationException("An error occurred while retrieving orders: " + ex.Message, ex);
                }
            }

            return ordersTable;
        }
    }
    }
