using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void CompareTest()
        {
            int n = 1001;
            string result;
            result = Logic.Compare(n);
            Assert.AreEqual("10 рублей 1 копейка", result);
        }
        public void CompareTest2()
        {
            int n = 456;
            string result;
            result = Logic.Compare(n);
            Assert.AreEqual("4 рубля 56 копеек", result);
        }
    }
}