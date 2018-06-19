using Microsoft.VisualStudio.TestTools.UnitTesting;
using domain.Entities;

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
        }
    }
}
