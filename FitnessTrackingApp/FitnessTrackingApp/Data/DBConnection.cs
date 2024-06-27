using System.Data.SqlClient;

namespace FitnessTrackingApp.Data
{
    public class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=TATENDA\\SQLEXPRESS;Initial Catalog=FitnessTrackingDB;Integrated Security=True;");
            con.Open();
            return con;
        }
    }
}