using System;

namespace CPF
{
    public class Cpf
    {
        public string Formatar(string cpf)
        {
            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }

        public String RaizDoCPF(string cpf)
        {
            return cpf.Substring(0, 2);
        }
    }
}