using System;
using ExampleSRP.src.Correct.Model;
using ExampleSRP.src.Correct.Model.Validator;

namespace ExampleSRP.src.Correct.Service
{
    public static class ValidatorService
    {
        public static bool RunValidator(ClientValidator validatorClient, Client client)
        {
            var validator = validatorClient.Validate(client);

            if(validator.IsValid)
                return true;
            
            return false;
        }
    }
}