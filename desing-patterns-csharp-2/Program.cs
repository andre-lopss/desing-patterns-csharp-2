using desing_patterns_csharp_2.Cap9;
using System;

namespace desing_patterns_csharp_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf = "123445688";

            EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            //Cliente cliente = facade.BuscaCliente(cpf);

            //var fatura = facade.CriaFatura(cliente, 5000);
            //facade.GeraCobranca(tipo.Boleto, fatura);

            Console.ReadKey();
        }
    }
}
