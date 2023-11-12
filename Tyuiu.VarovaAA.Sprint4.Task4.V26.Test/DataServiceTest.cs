using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VarovaAA.Sprint4.Task4.V26.Lib;
namespace Tyuiu.VarovaAA.Sprint4.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { { 5, 4, 1, 1, 2 },
                                            { 3, 2, 4, 3, 5 },
                                            { 5, 2, 3, 2, 2 },
                                            { 2, 5, 1, 1, 4 },
                                            { 5, 3, 4, 3, 2 } };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = { { 0, 4, 0, 0, 2 },
                            { 0, 2, 4, 0, 0 },
                            { 0, 2, 0, 2, 2 },
                            { 2, 0, 0, 0, 4 },
                            { 0, 0, 4, 0, 2 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
