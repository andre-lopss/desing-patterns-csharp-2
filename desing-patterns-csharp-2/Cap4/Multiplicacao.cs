using desing_patterns_csharp_2.Cap5;

namespace desing_patterns_csharp_2.Cap4
{
    class Multiplicacao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Multiplicacao(IExpressao Esquerda, IExpressao Direita)
        {
            this.Esquerda = Esquerda;
            this.Direita = Direita;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeMultiplicacao(this);
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda * valorDireita;
        }
    }
}
