using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using LeshanTicketSystem.Model;
using System.Threading.Tasks;
using System.Data;

namespace LeshanTicketSystem.DAL
{
    public static class OrderDAL
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString;

        public static bool DeleteById(int orderid)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM orders WHERE order_id = @orderid";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@orderid", orderid);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool UpdateOrder(Order order)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"UPDATE orders 
                       SET name = @name, sex = @sex, phone = @phone, id_card = @id_card, price = @price
                       WHERE order_id = @order_id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", order.Name);
                    cmd.Parameters.AddWithValue("@sex", order.Sex);
                    cmd.Parameters.AddWithValue("@phone", order.Phone);
                    cmd.Parameters.AddWithValue("@id_card", order.IdCard);
                    cmd.Parameters.AddWithValue("@price", order.Price);
                    cmd.Parameters.AddWithValue("@order_id", order.OrderId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool InsertOrder(Order order)
        {
            string sql = "INSERT INTO orders (order_id, name, sex, phone, id_card, price) VALUES (@order_id, @name, @sex, @phone, @id_card, @price)";


            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@order_id", order.OrderId);
                    cmd.Parameters.AddWithValue("@name", order.Name);
                    cmd.Parameters.AddWithValue("@sex", order.Sex);
                    cmd.Parameters.AddWithValue("@phone", order.Phone);
                    cmd.Parameters.AddWithValue("@id_card", order.IdCard);
                    cmd.Parameters.AddWithValue("@price", order.Price);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;  // 返回是否插入成功
                }
            }
            catch (Exception ex)
            {
                // 将异常抛出，UI 层可以捕获它并显示消息框
                throw new ApplicationException("插入失败: " + ex.Message);
            }
        }

        //实现搜索
        public static DataTable SearchOrders(string keyword)
        {
            DataTable table = new DataTable();
            string query = @"
        SELECT id, order_id, name, sex, phone, id_card, price
        FROM orders
        WHERE 
            CAST(order_id AS CHAR) LIKE @kw OR
            name LIKE @kw OR
            phone LIKE @kw OR
            id_card LIKE @kw";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
            }

            return table;
        }


    }


}
