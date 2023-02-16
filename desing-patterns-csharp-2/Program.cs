using desing_patterns_csharp_2.Cap4;
using desing_patterns_csharp_2.Cap5;
using System;

namespace desing_patterns_csharp_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());

            ImpressoraVisitor impressora = new ImpressoraVisitor();
            soma.Aceita(impressora);

            Console.ReadKey();
        }
    }
}
