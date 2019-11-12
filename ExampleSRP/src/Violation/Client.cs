using System;

namespace ExampleSRP.src.Violation
{
    // Example Implementation - Violation SRP
    public class Client
    {
        // public int Id { get; set; }
        // public string Name { get; set; }
        // public string Email { get; set; }
        // public string CPF { get; set; }
        // public DateTime DateReg { get; set; }

        // public Client() { }

        // public string SaveClient(Client client)
        // {
        //     if(!this.Email.Contains("@"))
        //         return "Client with email invalid!";

        //     if(this.CPF.Length != 11)
        //         return "Client with CPF invalid!";
            
        //     using(var conn = new SqlConnection(""))
        //     {
                
        //         var command = new SqlCommand();
        //         command.CommandType = CommandType.Text;
        //         command.CommandText = "INSERT INTO tblProduto (Name, Email, CPF, DateReg) VALUES (@Name, @Email, @CPF, @DateReg)";

        //         command.Parameters.AddWithValue("@Name", client.Name);
        //         command.Parameters.AddWithValue("@Email", client.Email);
        //         command.Parameters.AddWithValue("@CPF", client.CPF);
        //         command.Parameters.AddWithValue("@DateReg", client.DateReg);

        //         conn.Open();
        //         command.ExecuteNonQuery();
        //     }

        //     var mail = new MailMessage("", client.Email);
        //     var cli = new SmtpClient
        //     {
        //         Port = 25,
        //         DeliveryMethod = SmtpDeliveryMethod.Network,
        //         UseDefaultCredentials = false,
        //         Host = "smtp.google.com"
        //     };

        //     mail.Subject = "Bem Vindo!";
        //     mail.Body = "Parabéns! Você está cadastrado";
        //     cli.Send(mail);

        //     return "Cliente Cadastrado com Sucesso!";
        //}
    }
}