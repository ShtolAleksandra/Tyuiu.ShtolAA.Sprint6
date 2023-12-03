using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShtolAA.Sprint6.Task1.V12.Lib;

namespace Tyuiu.ShtolAA.Sprint6.Task1.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonVip_SAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_SAA.Text);
                int stopStep = Convert.ToInt32(textBoxKonec_SAA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_SAA.Text = "";
                textBoxResult_SAA.AppendText("+----------+-----------+" + Environment.NewLine);
                textBoxResult_SAA.AppendText("|    X     +    f(x)   |" + Environment.NewLine);
                textBoxResult_SAA.AppendText("+----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}   |", startStep, valueArray[i]);
                    textBoxResult_SAA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_SAA.AppendText("+----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravka_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИИПб-23-3 Штоль Александра Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
