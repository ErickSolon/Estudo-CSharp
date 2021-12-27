using System;

namespace cpqiestudo
{
    class Program
    {
        enum ContaEnumerador
        {
            CORRENTE,
            POUPANÇA
        }

        static void Main(string[] args)
        {
            Conta conta = new();
            Console.WriteLine($"Tipo de conta: {ContaEnumerador.POUPANÇA}, Número da conta: {conta.numeroDaConta()}, Data de abertura: {conta.DataAbertura().ToString("dd/MM/yyyy")}, Saldo total: {conta.MostrarSaldo()} R$");
            Console.WriteLine($"Tipo de conta: {ContaEnumerador.POUPANÇA}, Número da conta: {conta.numeroDaConta()}, de abertura: {conta.DataAbertura().ToString("dd/MM/yyyy")}, Saldo total - valor de retirada (500 R$): {conta.RetirarValor(500.0)} R$");
            Console.WriteLine($"Tipo de conta: {ContaEnumerador.POUPANÇA}, Número da conta: {conta.numeroDaConta()}, Data de abertura: {conta.DataAbertura().ToString("dd/MM/yyyy")}, Saldo total + valor inserido (1000 R$): {conta.InserirValor(1000.0)} R$");
        }
    }
}
