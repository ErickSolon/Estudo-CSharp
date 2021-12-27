using System;

namespace cadastro
{
    public interface IUsuarios
    {
        string PF(string cpf, string rg, string nome, DateTime nascimento, string contato, string enderecoCompleto);
        string PJ(string cnpj, string razaoSocial, string nome, string contato, DateTime dataAbertura, string enderecoCompleto);
    }
}