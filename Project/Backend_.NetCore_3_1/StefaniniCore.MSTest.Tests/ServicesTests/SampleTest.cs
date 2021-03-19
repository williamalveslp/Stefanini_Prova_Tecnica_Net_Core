using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StefaniniCore.MSTest.Tests.ServicesTests
{
    [TestClass]
    public class SampleTest
    {
        [TestMethod]
        public void SumNumbersFailed()
        {
            Assert.AreEqual(1, 0);
        }

        [TestMethod]
        public void SumNumbersPassed()
        {
            Assert.AreEqual(5, 5);
        }
    }
}
