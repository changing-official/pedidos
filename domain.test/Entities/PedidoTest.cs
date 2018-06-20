using Microsoft.VisualStudio.TestTools.UnitTesting;
using domain.Entities;
using System.Linq;
using System.Collections.Generic;

namespace domain.test
{
    [TestClass]
    public class PedidoTest
    {
        private Pedido _pedido;

        [TestInitialize]
        public void SetUp()
        {
            _pedido = new Pedido();
        }

        [TestMethod]
        public void TestPedidoInstance()
        {
            Assert.IsNotNull(_pedido);
            Assert.IsNotNull(_pedido.Itens);
            Assert.AreEqual(null, _pedido.Cliente);
        }

        [TestMethod]
        public void TestItensMustBeGreaterThanZero()
        {
            _pedido.Itens.Add(new Item());

            var firstPedido = _pedido.Itens.First();

            Assert.IsNotNull(firstPedido);

            Assert.IsTrue(firstPedido.Quantidade > 0);

             Assert.ThrowsException<System.Exception>(
                 () => firstPedido.Quantidade = 0
                 , "Quantidade deve ser maior que zero");
            
        }
    }
}
