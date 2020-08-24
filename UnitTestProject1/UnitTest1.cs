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
            int y = 15;
            //int z = x + y;
            CalcService calcService = new CalcService();
            int result = calcService.Add(x, y);
            Assert.AreEqual(15, result);
        }

        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void TestMethod2()
        //{
        //    int x = int.Parse("10g");
        //    int y = 5;
        //    CalculatorController calculatorController = new CalculatorController();
        //    var result = calculatorController.Add(x, y);
        //    Assert.AreEqual(15, result);
        //}


        //[TestMethod]
        //public void TestMethod3()
        //{
        //    int x = 10;
        //    int y = 5;
        //    CalculatorController calculatorController = new CalculatorController();
        //    var result = calculatorController.Add(x, y);
        //    Assert.AreEqual(15, result);
        //}


    }
}
