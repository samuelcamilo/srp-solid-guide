using System;
using ExampleSRP.src.Correct.Service;
using FluentValidation;

namespace ExampleSRP.src.Correct.Model.Validator
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(client => client.Name)
                .NotEmpty()
                .WithMessage("Propriedade {PropertyName} deverá ser diferente de vazia.")
                .Length(2,100)
                .WithMessage("Propriedade {PropertyName} deve possuir no minimo {MinLength} e no máximo {MaxLength} caracteres.");
            
            RuleFor(client => EmailService.IsValid(client.Email)).Equal(true)
                .WithMessage("Campo {PropertyName} inválido.");   

            RuleFor(client => CPFService.IsValid(client.CPF)).Equal(true)
                .WithMessage("Campo {PropertyName} inválido.");         
        }
    }
}