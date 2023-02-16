using desing_patterns_csharp_2.Cap3;
using System;

namespace desing_patterns_csharp_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Historico historico = new Historico();

            Contrato contrato = new Contrato(DateTime.Now, "André", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            Console.WriteLine(contrato.Tipo);

            Console.WriteLine(historico.Pega(1).Contrato.Tipo);

            Console.ReadKey();
        }
    }
}
