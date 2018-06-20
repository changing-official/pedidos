
namespace domain.Entities
{
    public class ItemPedido
    {
        public ItemPedido()
        {
            Quantidade = 1;
            Preco = 0.01M;
        }

        public ItemPedido(string produto, decimal precoSugerido) : this()
        {
            NomeProduto = produto;
            Preco = precoSugerido;
        }

        public string NomeProduto { get; set; }

        private decimal _preco;
        public decimal Preco
        {
            get { return _preco; }
            set
            {
                if (value < 0.01M) throw new System.Exception();
                _preco = value;
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
    }
}
