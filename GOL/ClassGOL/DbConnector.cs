using System.Data;
using System.Data.SqlClient;

namespace ClassGOL
{
    public class DbConnector
    {
        private string connectionString = "server=localhost;user=GOLD;database=G.O.L;port=3306;password=Pa$$w0rd;";
        private SqlConnection connection;

        public void Connect()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void ExecuteQuery(string query)
        {
            using (var command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void ExecuteCommand(SqlCommand command)
        {
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Close()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}