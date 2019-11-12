using System;
using FluentValidation;

namespace ExampleSRP.src.Correct.Model.Validator
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(client => client.Name).NotNull().WithMessage("");
        }
    }
}