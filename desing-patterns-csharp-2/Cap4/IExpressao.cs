using desing_patterns_csharp_2.Cap5;

namespace desing_patterns_csharp_2.Cap4
{
    interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor impressora);
    }
}
