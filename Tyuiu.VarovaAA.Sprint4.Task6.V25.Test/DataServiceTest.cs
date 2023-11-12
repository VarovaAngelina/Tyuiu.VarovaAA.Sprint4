using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VarovaAA.Sprint4.Task6.V25.Lib;
namespace Tyuiu.VarovaAA.Sprint4.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var words = new string[] { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };
            int res = ds.Calculate(words);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
