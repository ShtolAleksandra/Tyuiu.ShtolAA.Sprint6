using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShtolAA.Sprint6.Task6.V29.Lib;
using System.IO;

namespace Tyuiu.ShtolAA.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_SAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask6_SAA.ShowDialog();
            openFilePath = openFileDialogTask6_SAA.FileName;
            textBoxInPut_SAA.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_SAA.Text = groupBoxInPut_SAA.Text + " " + openFileDialogTask6_SAA.FileName;
            buttonDone_SAA.Enabled = true;
        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            textBoxOutPut_SAA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
