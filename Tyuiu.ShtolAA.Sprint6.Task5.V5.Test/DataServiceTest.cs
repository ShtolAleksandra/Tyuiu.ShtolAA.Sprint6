using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint6.Task5.V5.Lib;
using System.IO;

namespace Tyuiu.ShtolAA.Sprint6.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\aleks\source\repos\Tyuiu.ShtolAA.Sprint6\Tyuiu.ShtolAA.Sprint6.Task5.V5\bin\Debug\InPutFileTask5V5.txt";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
