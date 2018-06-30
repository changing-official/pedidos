
namespace domain.Entities
{
    public class ItemPedido
    {
        public ItemPedido()
        {
            Quantidade = 1;
            PrecoSugerido = 0.01M;
            Preco = 0.01M;
            Rentabilidade = Rentabilidade.Pendente;
        }

        public string NomeProduto { get; set; }

        public decimal PrecoSugerido { get; set; }

        private decimal _preco;
        public decimal Preco
        {
            get { return _preco; }
            set
            {
                if (value < 0.01M) throw new System.Exception();
                _preco = value;

                if (PrecoSugerido < _preco)
                    Rentabilidade = Rentabilidade.Otima;
            }
        }

        private int _quantidade;
        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (value < 1) throw new System.Exception();
                _quantidade = value;
            }
        }

        public Rentabilidade Rentabilidade { get; set; }
    }
}
