using System;

namespace CPF
{
    class Program
    {
        static void Main(string[] args)
        {
            Cpf cpf = new();
            Console.WriteLine("CPF: " + cpf.Formatar("13312312312"));
            Console.WriteLine("Raiz do CPF: " + cpf.RaizDoCPF("12312312312"));
        }
    }
}
