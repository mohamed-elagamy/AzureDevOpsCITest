using AzureDevOpsCITest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 10;
            int y = 15;
            //int z = x + y;
            CalcService calcService = new CalcService();
            int result = calcService.Add(x, y);
            Assert.AreEqual(15, result);
        }
    }
}
