using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShtolAA.Sprint6.Task0.V18.Lib;

namespace Tyuiu.ShtolAA.Sprint6.Task0.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {

                textBoxResult_SAA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_SAA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИИПб-23-3 Штоль Александра Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxVarX_SAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVarX_SAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void labelVarX_SAA_Click(object sender, EventArgs e)
        {

        }
    }
}
