using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ExampleSRP.src.Correct.Repository
{
    public class ConnectionRepository : IDisposable
    {
        private MySqlConnection connection;

        public ConnectionRepository()
        {
            this.connection = new MySqlConnection("Server=XXXX;Database=XXXX;Uid=XXXX;Pwd=XXXX;");
        }

        public MySqlConnection Open()
        {
            if(connection.State != ConnectionState.Open)
                connection.Open();

            return connection;
        }

        public void Close()
        {
            if(connection.State != ConnectionState.Closed)
                Dispose();
        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}