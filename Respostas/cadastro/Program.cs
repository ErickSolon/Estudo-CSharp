using System;

namespace cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuarios usuarios = new();

            Console.WriteLine("PF ou PJ? --> ");
            string escolha = Console.ReadLine();

            if (escolha == "PF")
            {
                Console.WriteLine("Digite seu CPF: ");
                string cpf = Console.ReadLine();
                Console.WriteLine("Digite seu RG: ");
                string rg = Console.ReadLine();
                Console.WriteLine("Digite seu Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite sua data de nascimento (exemplo: 01/01/2001):");
                DateTime nascimento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Seu contato: ");
                string contato = Console.ReadLine();
                Console.WriteLine("Endereço completo: ");
                string enderecoCompleto = Console.ReadLine();

                Console.WriteLine(usuarios.PF(cpf, rg, nome, nascimento, contato, enderecoCompleto));
            }
            else
            {
                Console.WriteLine("Digite seu cnpj: ");
                string cnpj = Console.ReadLine();
                Console.WriteLine("Digite sua razão social: ");
                string razaoSocial = Console.ReadLine();
                Console.WriteLine("Digite seu Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Seu contato: ");
                string contato = Console.ReadLine();
                Console.WriteLine("Digite data de abertura (exemplo: 01/01/2001): ");
                DateTime dataAbertura = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Endereço completo: ");
                string enderecoCompleto = Console.ReadLine();

                Console.WriteLine(usuarios.PJ(cnpj, razaoSocial, nome, contato, dataAbertura, enderecoCompleto));
            }
        }
    }
}
