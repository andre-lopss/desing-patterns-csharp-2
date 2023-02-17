using System;

namespace desing_patterns_csharp_2.Cap6
{
    class EnviaPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por e-mail.");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
