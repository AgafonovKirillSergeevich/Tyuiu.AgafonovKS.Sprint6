using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AgafonovKS.Sprint6.Task5.V25.Lib;
using System.IO;

namespace Tyuiu.AgafonovKS.Sprint6.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Kirya\source\repos\Tyuiu.AgafonovKS.Sprint6\Tyuiu.AgafonovKS.Sprint6.Task5.V25\bin\Debug\InPutFileTask5V25.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
