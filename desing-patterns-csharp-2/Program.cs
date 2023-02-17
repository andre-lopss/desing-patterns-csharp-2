using desing_patterns_csharp_2.Cap7;
using System;

namespace desing_patterns_csharp_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido pedido1 = new Pedido("André", 1000.0);
            Pedido pedido2 = new Pedido("Marcos", 200.0);
            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));
            fila.Adiciona(new FinalizaPedido(pedido2));

            fila.Processa();

            Console.ReadKey();
        }
    }
}
