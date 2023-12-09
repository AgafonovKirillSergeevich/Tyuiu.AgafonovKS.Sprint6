using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AgafonovKS.Sprint6.Task4.V22.Lib;

namespace Tyuiu.AgafonovKS.Sprint6.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\OutPutFileTask4.txt";
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 8.04;
            valueWaitArray[1] = 6.68;
            valueWaitArray[2] = 4.84;
            valueWaitArray[3] = 1.76;
            valueWaitArray[4] = 0.45;
            valueWaitArray[5] = 0.5;
            valueWaitArray[6] = -0.87;
            valueWaitArray[7] = -2.42;
            valueWaitArray[8] = -3.88;
            valueWaitArray[9] = -6.83;
            valueWaitArray[10] = -8.88;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);


            for (int i = 0; i < valueWaitArray.Length; i++)
            {
                valueWaitArray[i] = Math.Round(valueWaitArray[i], 2);
            }
        }
    }
}
