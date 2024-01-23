using Microsoft.EntityFrameworkCore;
using RepositorioModulo9;
using ServicioTests;

namespace TestProjectM9
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Prueba pr = new Prueba(100);

            Assert.AreEqual(110, pr.GetPriceWithTax(10));
            Assert.AreNotEqual(11230, pr.GetPriceWithTax(10));

            

        }
    }
}