using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DL
{   
    public class AccountDao
    {
        private MySqlConnection conn;
        String connectionString;
        public AccountDao() {
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "root", "bilete");
            conn = new MySqlConnection(connectionString);
        }

        public String getUser(String username, String password)
        {
            String u = "";
            String sql = "SELECT * FROM cont WHERE username= '" + username + "' AND password='" + password + "'";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    u = reader["rol"].ToString();
                }
                else
                {
                    u = "";
                }
                conn.Close();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
                return null;
            }
            return u;
        }

        public void createAngajat(String username, String password)
        {
            String sql = "insert into cont (name,username,password,rol)  VALUES ( '" + username + "','" + username + "','"+password+"','Angajat');";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
           
            }
 
        }

        public void updatePassword(String username, String password)
        {
            String sql = "update cont set password = '" + password + "' where username ='" + username + "';";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();

            }

        }

    }
}
