using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VarovaAA.Sprint4.Task2.V6.Lib;
namespace Tyuiu.VarovaAA.Sprint4.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 8 };

            int res = ds.Calculate(numsArray);
            int wait = 1594323;

            Assert.AreEqual(wait, res);
        }
    }
}
