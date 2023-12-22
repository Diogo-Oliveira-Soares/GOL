using System.Data;
using System.Data.SqlClient;


namespace TestClassGOL
{
    public class TestDbConnector
    {
        private string connectionString = "server=localhost;user=GOLD;database=G.O.L;port=3306;password=Pa$$w0rd;";
        private SqlConnection _connection;

        [SetUp]
        public void Setup()
        {
            _connection = new SqlConnection(connectionString);
        }

        [Test]
        public void ConnectToDB_ConnectionSuccess()
        {
            //given

            //when
            _connection.Open();

            //then
            Assert.That(_connection.State, Is.EqualTo(ConnectionState.Open));
        }
    }
}
