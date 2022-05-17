using System;
using MySql.Data.MySqlClient;
using System.Data;
namespace WebApplication2.AppCode
{
    public class DataAccess
    {
        string connection = "Server=localhost;Uid=root;Database=homework;Port=3306;";
        public DataAccess()
        {
        }
        public DataAccess(string _connection)
        {
            connection = _connection;
        }
        public DataTable QueryData(string sqlQuery) { 
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            MySqlDataAdapter adr = new MySqlDataAdapter(sqlQuery, conn);
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt); //opens and closes the DB connection automatically !! (fetches from pool)
            conn.Close();

            return dt;
        }
        public int ChangeData(string sqlChange) { 
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand comm = new MySqlCommand(sqlChange, conn);
            conn.Open();
            int status = comm.ExecuteNonQuery();
            conn.Close();
            return status;
        }
    }
}
