using System;
using System.Collections.Generic;

namespace desing_patterns_csharp_2.Cap3
{
    class Historico
    {
        private IList<Estado> Estados = new List<Estado>();

        public void Adiciona(Estado estado)
        {
            Estados.Add(estado);
        }

        public Estado Pega(int indice)
        {
            return Estados[indice];
        }
    }
}
