using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.ShtolAA.Sprint6.Task4.V6.Lib;

namespace Tyuiu.ShtolAA.Sprint6.Task4.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void labelStopStep_SAA_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            try
            {
                int StartStep = Convert.ToInt32(textBoxStartStep_SAA.Text);
                int StopStep = Convert.ToInt32(textBoxStopStep_SAA.Text);

                int len = ds.GetMassFunction(StartStep, StopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(StartStep, StopStep);

                this.chartFunction_SAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SAA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_SAA.Text = "";

                chartFunction_SAA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_SAA.Series[0].Points.AddXY(StartStep, valueArray[i]);
                    textBoxResult_SAA.AppendText(valueArray[i] + Environment.NewLine);
                    StartStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_SAA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V6.txt";
                File.WriteAllText(path, textBoxResult_SAA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxResult_SAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInfo_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИИПб-23-3 Штоль Александра Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

