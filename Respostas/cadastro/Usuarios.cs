using System;

namespace cadastro
{
    public class Usuarios : IUsuarios
    {
        public string PF(string cpf, string rg, string nome, DateTime nascimento, string contato, string enderecoCompleto)
        {
            return $"PF cadastrado! {cpf}, {rg}, {nome}, {nascimento}, {contato}, {enderecoCompleto}";
        }

        public string PJ(string cnpj, string razaoSocial, string nome, string contato, DateTime dataAbertura, string enderecoCompleto)
        {
            return $"PJ cadastrado! {cnpj}, {razaoSocial}, {nome}, {contato}, {dataAbertura}, {enderecoCompleto}";
        }
    }
}