using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyClass objMyClass = new MyClass();
            int sum = objMyClass.Sum(10, 10);
            Assert.AreEqual(20, sum);
        }
    }
}
