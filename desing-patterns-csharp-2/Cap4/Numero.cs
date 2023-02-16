using desing_patterns_csharp_2.Cap5;

namespace desing_patterns_csharp_2.Cap4
{
    class Numero : IExpressao
    {
        public int Valor { get; private set; }

        public Numero(int numero)
        {
            this.Valor = numero;
        }

        public int Avalia()
        {
            return this.Valor;
        }

        public void Aceita(ImpressoraVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }
    }
}
