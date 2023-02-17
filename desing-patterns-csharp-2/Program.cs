using desing_patterns_csharp_2.Cap6;
using System;

namespace desing_patterns_csharp_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IMensagem mensagem = new MensagemAdministrativa("André");
            IEnviador enviador = new EnviaPorSMS();
            mensagem.Enviador = enviador;
            mensagem.Envia();

            Console.ReadKey();
        }
    }
}
