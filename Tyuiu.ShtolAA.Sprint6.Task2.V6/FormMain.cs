﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShtolAA.Sprint6.Task2.V6.Lib;

namespace Tyuiu.ShtolAA.Sprint6.Task2.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonVip_SAA_MouseEnter(object sender, EventArgs e)
        {
            buttonVip_SAA.BackColor = Color.Red;
        }

        private void buttonVip_SAA_MouseLeave(object sender, EventArgs e)
        {
            buttonVip_SAA.BackColor = Color.Green;
        }

        private void buttonSpravka_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИИПб-23-3 Штоль Александра Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        DataService ds = new DataService();
        private void buttonVip_SAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_SAA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_SAA.Text);


                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_SAA.Titles.Add("График функции");

                this.chartFunction_SAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SAA.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_SAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_SAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    

