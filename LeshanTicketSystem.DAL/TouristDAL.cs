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
    public class TouristDAL
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString;

        public DataTable GetAllTourists()
        {
            DataTable dt = new DataTable();
            string query = "SELECT   id,name,sex,phone,id_card," +
                "CASE status WHEN 0 THEN '正常' " +
                "  WHEN 1 THEN '拉黑'" +
                " END AS t_status FROM tourist";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                try
                {
                    conn.Open();
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    // 这里不建议用 MessageBox，UI层再捕获
                    throw new Exception("数据库查询失败: " + ex.Message);
                }
            }

            return dt;
        }


        public static bool DeleteByIdCard(string idCard)
        {
            string sql = "DELETE FROM tourist WHERE id_card = @id_card";
            MySqlParameter[] parameters = { new MySqlParameter("@id_card", idCard) };
            return MySqlHelper.ExecuteNonQuery(connectionString, sql, parameters) > 0;
        }

        public static bool UpdateStatus(string idCard, int status)
        {
            string sql = "UPDATE tourist SET status = @status WHERE id_card = @id_card";
            MySqlParameter[] parameters = {
            new MySqlParameter("@status", status),
            new MySqlParameter("@id_card", idCard)
    };
            return MySqlHelper.ExecuteNonQuery(connectionString, sql, parameters) > 0;
        }

        //查询搜索游客
        public DataTable SearchTourists(string keyword, string status)
        {
            DataTable dt = new DataTable();

            string query = @"SELECT id, name, sex, phone, id_card,
                    CASE status 
                        WHEN 0 THEN '正常' 
                        WHEN 1 THEN '拉黑' 
                    END AS t_status
                FROM tourist
                WHERE (name LIKE @keyword OR phone LIKE @keyword OR id_card LIKE @keyword)";

            if (!string.IsNullOrEmpty(status))
            {
                if (status == "正常")
                {
                    query += " AND status = 0";
                }
                else if (status == "拉黑")
                {
                    query += " AND status = 1";
                }
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                try
                {
                    conn.Open();
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("搜索失败：" + ex.Message);
                }
            }

            return dt;
        }



    }
}
