using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.ShtolAA.Sprint6.Task4.V6.Lib;

namespace Tyuiu.ShtolAA.Sprint6.Task4.V6
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 23.92;
            valueWaitArray[1] = 18.88;
            valueWaitArray[2] = 13.10;
            valueWaitArray[3] = 7.24;
            valueWaitArray[4] = 1.80;
            valueWaitArray[5] = -8;
            valueWaitArray[6] = -5.70;
            valueWaitArray[7] = -11.26;
            valueWaitArray[8] = -17.12;
            valueWaitArray[9] = -22.88;
            valueWaitArray[10] = -27.92;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }

        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\aleks\source\repos\Tyuiu.ShtolAA.Sprint6\Tyuiu.ShtolAA.Sprint6.Task4.V6\bin\Debug\OutPutFileTask4V6.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
