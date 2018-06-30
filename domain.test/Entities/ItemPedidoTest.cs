using domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace domain.test
{
    [TestClass]
    public class ItemPedidoTest
    {
        private ItemPedido _itemPedido;

        [TestInitialize]
        public void SetUp()
        {
            _itemPedido = new ItemPedido();
        }

        [TestMethod]
        public void TestProdutoItemPedidoInstance()
        {
            Assert.IsNull(_itemPedido.NomeProduto);
        }

        [TestMethod]
        public void TestQuantidadeItensMustBeGreaterThanZero()
        {
            Assert.IsNotNull(_itemPedido);

            Assert.IsTrue(_itemPedido.Quantidade > 0);

            Assert.ThrowsException<System.Exception>(
                 () => _itemPedido.Quantidade = 0
                 , "Quantidade deve ser maior que zero");

        }

        [TestMethod]
        public void TestPrecoItensMustBeGreaterThanZero()
        {
            Assert.IsNotNull(_itemPedido.Preco);
            Assert.IsTrue(_itemPedido.Preco > 0);
            Assert.ThrowsException<System.Exception>(
                 () => _itemPedido.Preco = 0
                 , "Preço deve ser maior que zero");
        }

        [TestMethod]
        public void TestRentabilidadeShouldBePendente()
        {
            Assert.AreEqual(Rentabilidade.Pendente, _itemPedido.Rentabilidade);
        }

        [TestMethod]
        public void TestOtimaRentabilidadeForPrecoProdutoMaiorQueSugerido()
        {
            var precoProduto = 6000M;

            _itemPedido = new ItemPedido();

            _itemPedido.NomeProduto = "X-Wing";
            _itemPedido.PrecoSugerido = precoProduto;

            _itemPedido.Preco = precoProduto + 0.01M;

            Assert.AreEqual(Rentabilidade.Otima, _itemPedido.Rentabilidade);
        }
    }
}