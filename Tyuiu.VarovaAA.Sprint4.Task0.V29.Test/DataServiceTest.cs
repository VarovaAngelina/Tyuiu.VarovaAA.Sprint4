using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VarovaAA.Sprint4.Task0.V29.Lib;
namespace Tyuiu.VarovaAA.Sprint4.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int res = ds.GetSumOddArrEl(numsArray);
            int wait = 32;
            Assert.AreEqual(wait, res);
        }
    }
}
