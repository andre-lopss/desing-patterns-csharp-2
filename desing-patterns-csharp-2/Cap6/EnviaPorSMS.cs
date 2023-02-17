using System;

namespace desing_patterns_csharp_2.Cap6
{
    class EnviaPorSMS : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por SMS.");
            Console.WriteLine(mensagem.Formata());
        }
    }
}