using desing_patterns_csharp_2.Cap5;

namespace desing_patterns_csharp_2.Cap4
{
    class Divisao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Divisao(IExpressao Esquerda, IExpressao Direita)
        {
            this.Esquerda = Esquerda;
            this.Direita = Direita;
        }

        public void Aceita(ImpressoraVisitor impressora)
        {
            impressora.ImprimeDivisao(this);
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda / valorDireita;
        }
    }
}
