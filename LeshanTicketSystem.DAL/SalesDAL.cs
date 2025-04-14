using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeshanTicketSystem.DAL
{
    public class SalesDAL
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString;

        // 获取每日的销售数据
        public DataTable GetDailySales()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT sale_date, adult_tickets, child_tickets, total_amount FROM ticket_sales ORDER BY sale_date ASC";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                conn.Open();
                adapter.Fill(dt);
            }

            return dt;
        }
    }
}
