using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShtolAA.Sprint6.Task7.V26.Lib;


namespace Tyuiu.ShtolAA.Sprint6.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            string path = @"C:\Users\aleks\source\repos\Tyuiu.ShtolAA.Sprint6\Tyuiu.ShtolAA.Sprint6.Task7.V26\bin\Debug\InPutFileTask7V26.csv";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
