using AzureDevOpsCITest;
using AzureDevOpsCITest.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 10;
            int y = 5;
            //int z = x + y;
            CalcService calcService = new CalcService();
            int result = calcService.Add(x, y);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int x = 10;
            int y = 5;
            CalculatorController calculatorController = new CalculatorController();
            var result = calculatorController.Add(x, y);
            Assert.AreEqual(15, result);
        }

       

        [TestMethod]
        public void TestMethod4()
        {
            try
            {
                int x = 10;
                int y = 5;
                CalculatorController calculatorController = new CalculatorController();
                var result = calculatorController.Add(x, y);
                Assert.AreEqual(15, result);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

       
    }
}
