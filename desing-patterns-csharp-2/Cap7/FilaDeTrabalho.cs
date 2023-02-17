using System.Collections.Generic;

namespace desing_patterns_csharp_2.Cap7
{
    class FilaDeTrabalho
    {
        private IList<IComando> Comandos = new List<IComando>();

        public void Adiciona(IComando comando)
        {
            this.Comandos.Add(comando);
        }

        public void Processa()
        {
            foreach(var comando in this.Comandos)
            {
                comando.Executa();
            }
        }
    }
}
