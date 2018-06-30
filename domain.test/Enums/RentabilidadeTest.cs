using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace domain.test
{
    [TestClass]
    public class RentabilidadeTest
    {
        [TestMethod]
        public void TestRentabilidadeItemOptions()
        {
            Assert.AreEqual((int)Rentabilidade.Pendente, 0);
            Assert.AreEqual((int)Rentabilidade.Otima, 1);
            Assert.AreEqual((int)Rentabilidade.Boa, 2);
            Assert.AreEqual((int)Rentabilidade.Ruim, 3);
        }
    }
}