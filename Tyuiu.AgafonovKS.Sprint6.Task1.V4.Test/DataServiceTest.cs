using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AgafonovKS.Sprint6.Task1.V4.Lib;

namespace Tyuiu.AgafonovKS.Sprint6.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            int len = stop - start + 1;
            double[] wait = new double[len];
            wait[0] = 7.83;
            wait[1] = 6.22;
            wait[2] = 6.36;
            wait[3] = 6.96;
            wait[4] = -0.52;
            wait[5] = 0.00;
            wait[6] = -3.30;
            wait[7] = -5.53;
            wait[8] = -6.25;
            wait[9] = -6.63;
            wait[10] = -8.24;
            double[] res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
