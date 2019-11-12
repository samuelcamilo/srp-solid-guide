using System;
using System.Data;
using ExampleSRP.src.Correct.Model;
using MySql.Data.MySqlClient;

namespace ExampleSRP.src.Correct.Repository
{
    public class ClientRepository
    {
        private ConnectionRepository connectionRepository;

        public ClientRepository()
        {
            this.connectionRepository = new ConnectionRepository();
        }

        public void SaveClient(Client client)
        {
            using(MySqlCommand command = connectionRepository.Open().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO clientes (nome, email, cpf, data_registro) VALUES (@name,@email,@cpf,@date_cad)";

                command.Parameters.AddWithValue("@name", client.Name);
                command.Parameters.AddWithValue("@email", client.Email);
                command.Parameters.AddWithValue("@cpf", client.CPF);
                command.Parameters.AddWithValue("@date_cad", client.DateReg);

                command.ExecuteNonQuery();
            }
        }
    }
}