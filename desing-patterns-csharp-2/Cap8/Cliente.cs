using System;

namespace desing_patterns_csharp_2.Cap8
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string endereco, DateTime dataDeNascimento)
        {
            Nome = nome;
            Endereco = endereco;
            DataDeNascimento = dataDeNascimento;
        }
    }
}
