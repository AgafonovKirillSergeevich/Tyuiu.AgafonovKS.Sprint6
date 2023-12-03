using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AgafonovKS.Sprint6.Task2.V29.Lib;

namespace Tyuiu.AgafonovKS.Sprint6.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = 28.85;
            valueWaitArray[1] = 21.04;
            valueWaitArray[2] = 15.03;
            valueWaitArray[3] = 11.75;
            valueWaitArray[4] = 9.62;
            valueWaitArray[5] = 4;
            valueWaitArray[6] = 1.62;
            valueWaitArray[7] = -8.25;
            valueWaitArray[8] = -14.97;
            valueWaitArray[9] = -18.96;
            valueWaitArray[10] = -21.15;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
