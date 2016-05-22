using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;


namespace DL
{
     public class SpectacoleDao
    {
        private MySqlConnection conn;
        String connectionString;
        public SpectacoleDao() {
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "root", "bilete");
            conn = new MySqlConnection(connectionString);
        }

        public void create(String titlu, String regia,String distributia,String data,Int32 numarbilete)
        {
            String sql = "insert into spectacole (titlu,regia,distributia,data,numarbilete)  VALUES ( '"
                + titlu + "','" + regia + "','" + distributia + "','" + data + "'," + numarbilete + ");";
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
        //read
        public DataTable read()
        {
            DataTable dtRecord = new DataTable();
            String sql = "select * from spectacole;";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
               
                dtRecord.Load(reader);
                conn.Close();
              
                 
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
                return null;
            }
            return dtRecord;
        }
        //update
        public void update(String titlu, String regia, String distributia, String data, Int32 numarbilete)
        {
            String sql = "update spectacole set regia = '"+regia+"',distributia = '"+distributia+"',data='"+data+"',numarbilete="+numarbilete+" where titlu='"+titlu+"';";
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
        //delete
        public void delete(String titlu)
        {
            String sql = "delete from spectacole where titlu = '"+titlu+"';";
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

