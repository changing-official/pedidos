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
        public void TestProdutoItensInstance()
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
        public void TestProdutoItensMustChangeItemPrice()
        {
            var precoProduto = 60000M;

            _itemPedido = new ItemPedido("X-Wing", precoSugerido: precoProduto);

            Assert.IsNotNull(_itemPedido);
            Assert.AreEqual("X-Wing", _itemPedido.NomeProduto);
            Assert.AreEqual(precoProduto, _itemPedido.Preco);
        }

    }
}