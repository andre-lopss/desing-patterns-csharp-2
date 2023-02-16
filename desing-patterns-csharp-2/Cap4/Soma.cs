using desing_patterns_csharp_2.Cap5;

namespace desing_patterns_csharp_2.Cap4
{
    class Soma :IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Soma(IExpressao Esquerda, IExpressao Direita)
        {
            this.Esquerda = Esquerda;
            this.Direita = Direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda + valorDireita;
        }

        public void Aceita(ImpressoraVisitor impressora)
        {
            impressora.ImprimeSoma(this);
        }
    }
}
