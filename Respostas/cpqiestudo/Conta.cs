using System;


namespace cpqiestudo
{
    public class Conta : IConta
    {
        byte numero = 10;
        DateTime dataAbertura = DateTime.Today;
        double saldo = 1500.0;
        double retirada;

        public double InserirValor(double inserirSaldo)
        {
            return this.saldo + inserirSaldo;
        }

        public double MostrarSaldo()
        {
            return this.saldo;
        }

        public double RetirarValor(double retirarSaldo)
        {
            this.retirada = this.saldo - retirarSaldo;
            return this.retirada;
        }

        public DateTime DataAbertura()
        {
            return this.dataAbertura;
        }

        public byte numeroDaConta()
        {
            return this.numero;
        }
    }
}