using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DL
{
    public class BileteDao
    {
        private MySqlConnection conn;
        String connectionString;

        public BileteDao()
        {
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "root", "bilete");
            conn = new MySqlConnection(connectionString);
        }



        public void create(String spectacol, Int32 rand, Int32 numar)
        {
            String sql = "insert into bilete (spectacol,rand,numar)  VALUES ( '"
                + spectacol + "'," + rand + "," + numar + ");";
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

        public DataTable read(String spectacol)
        {
            DataTable dtRecord = new DataTable();
            String sql = "select * from bilete where spectacol = '"+spectacol+"';";
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

    }  
}
