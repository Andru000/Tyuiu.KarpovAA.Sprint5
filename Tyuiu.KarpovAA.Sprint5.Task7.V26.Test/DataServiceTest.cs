using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint5.Task7.V26.Lib;
using System.IO;

namespace Tyuiu.KarpovAA.Sprint5.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\1\source\repos\Tyuiu.KarpovAA.Sprint5\Tyuiu.KarpovAA.Sprint5.Task7.V26\bin\Debug\OutPutFileTask7.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
