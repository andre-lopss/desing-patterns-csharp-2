using desing_patterns_csharp_2.Cap8;
using System;

namespace desing_patterns_csharp_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("André", "Rua tal", DateTime.Now);

            string xml = new GeradorDeXml().GeraXml(cliente);

            Console.WriteLine(xml);

            Console.ReadKey();
        }
    }
}
