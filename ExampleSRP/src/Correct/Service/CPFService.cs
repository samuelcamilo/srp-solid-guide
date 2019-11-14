using System;

namespace ExampleSRP.src.Correct.Service
{
    public static class CPFService
    {
        public static bool IsValid(string cpf)
        {
            if(cpf.Length != 11)
                return false;
            
            return true;
        }

    }
}