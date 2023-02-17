namespace desing_patterns_csharp_2.Cap6
{
    class MensagemCliente : IMensagem
    {
        public IEnviador Enviador { get; set; }
        private string nome;

        public MensagemCliente(string nome)
        {
            this.nome = nome;
        }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando mensagem para o cliente {0}", nome);
        }
    }
}
