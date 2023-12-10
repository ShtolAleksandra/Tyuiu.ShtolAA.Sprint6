﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShtolAA.Sprint6.Task5.V5.Lib;

namespace Tyuiu.ShtolAA.Sprint6.Task5.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\aleks\source\repos\Tyuiu.ShtolAA.Sprint6\Tyuiu.ShtolAA.Sprint6.Task5.V5\bin\Debug\InPutFileTask5V5.txt";

   

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_SAA.ColumnCount = 2;
            dataGridViewOutPut_SAA.Columns[0].Width = 20;
            dataGridViewOutPut_SAA.Columns[1].Width = 50;

            this.chartDiag_SAA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_SAA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_SAA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutPut_SAA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_SAA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_SAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб-23-3 Штоль Александра Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
