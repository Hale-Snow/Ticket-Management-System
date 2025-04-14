using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using LeshanTicketSystem.Model;

namespace LeshanTicketSystem.DAL
{
    public class AdminDAL
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString;
        public Admin GetAdminByUidAndPassword(string uid, string password)
        {
            Admin admin = null;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM admin WHERE uid=@uid AND password=@password";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", uid);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            admin = new Admin
                            {
                                Id = reader.GetInt32("id"),
                                Uid = reader.GetString("uid"),
                                Password = reader.GetString("password"),
                                Phone = reader.GetString("phone"),
                                Sex = reader.GetString("sex")
                            };
                        }
                    }
                }
            }

            return admin;
        }


        public List<Admin> GetAllAdmins()
        {
            var list = new List<Admin>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT id, uid, password, phone, sex FROM admin";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Admin
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Uid = reader["uid"].ToString(),
                            Password = reader["password"].ToString(),
                            Phone = reader["phone"].ToString(),
                            Sex = reader["sex"].ToString()
                        });
                    }
                }
            }
            return list;
        }


        //管理员管理
        public string GetPassword(string uid)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT password FROM admin WHERE uid = @uid";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", uid);
                    var result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        public void UpdatePassword(string uid, string newPass)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE admin SET password = @newPass WHERE uid = @uid";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@newPass", newPass);
                    cmd.Parameters.AddWithValue("@uid", uid);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteAdmin(string uid)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM admin WHERE uid = @uid";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", uid);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }


}
