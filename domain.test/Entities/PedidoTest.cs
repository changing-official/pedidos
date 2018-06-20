using Microsoft.VisualStudio.TestTools.UnitTesting;
using domain.Entities;
using System.Linq;
using System.Collections.Generic;

namespace domain.test
{
    [TestClass]
    public class PedidoTest
    {
        [TestMethod]
        public void TestPedidoInstance()
        {
            var pedido = new Pedido();

            Assert.IsNotNull(pedido);
            Assert.IsNotNull(pedido.Itens);
            Assert.IsNull(pedido.Cliente);
        }
    }
}
