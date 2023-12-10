using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShtolAA.Sprint6.Task6.V29.Lib;

namespace Tyuiu.ShtolAA.Sprint6.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\Users\aleks\source\repos\Tyuiu.ShtolAA.Sprint6\Tyuiu.ShtolAA.Sprint6.Task6.V29\bin\Debug\InPutFileTask6V29.txt";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
