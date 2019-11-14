using System;

namespace ExampleSRP.src.Correct.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DateReg { get; set; }

        public Client() { }

        public Client(string _name, string _email, string _cpf)
        {
            this.Name = _name;
            this.Email = _email;
            this.CPF = _cpf;
            this.DateReg = DateTime.Now;
        }

    }
}