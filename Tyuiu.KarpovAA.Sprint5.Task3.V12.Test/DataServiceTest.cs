using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KarpovAA.Sprint5.Task3.V12.Lib;

namespace Tyuiu.KarpovAA.Sprint5.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\karpo\source\repos\Tyuiu.KarpovAA.Sprint5\Tyuiu.KarpovAA.Sprint5.Task3.V12\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
             
        }
    }
}
