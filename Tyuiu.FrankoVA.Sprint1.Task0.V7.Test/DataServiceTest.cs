using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FrankoVA.Sprint1.Task0.V7.Lib;
namespace Tyuiu.FrankoVA.Sprint1.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(5, res);
        }
    }
}
