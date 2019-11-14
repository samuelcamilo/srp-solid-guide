using System;
using ExampleSRP.src.Correct.Model;
using ExampleSRP.src.Correct.Model.Validator;
using ExampleSRP.src.Correct.Service;
using ExampleSRP.src.Correct.Repository;

namespace ExampleSRP
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientRepository clientRepository = new ClientRepository();
            Client client = new Client("Samuel Camilo Dos Santos", "ssamuelcamilo@gmail.com", "02980799335");

            if(ValidatorService.RunValidator(new ClientValidator(), client))
            {
                clientRepository.SaveClient(client);
                // EmailService.SendEmail(client.Email, client.Email, "Seja Bem Vindo!", "Parabéns! Você está cadastrado");
            }

        }
    }
}
