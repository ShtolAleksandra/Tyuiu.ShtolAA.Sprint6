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
using Tyuiu.ShtolAA.Sprint6.Task7.V26.Lib;
namespace Tyuiu.ShtolAA.Sprint6.Task7.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask7_SAA.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SAA.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }


        private void buttonOpenFile_SAA_Click(object sender, EventArgs e)
        {
            toolTipButton_SAA.SetToolTip(buttonOpenFile_SAA, "Открыть файл");
            openFileDialogTask7_SAA.ShowDialog();
            openFilePath = openFileDialogTask7_SAA.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_SAA.ColumnCount = columns;
            dataGridViewInPut_SAA.RowCount = rows;
            dataGridViewOutPut_SAA.ColumnCount = columns;
            dataGridViewOutPut_SAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_SAA.Columns[i].Width = 25;
                dataGridViewOutPut_SAA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_SAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_SAA.Enabled = true;
        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_SAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_SAA.Enabled = true;
        }

        private void buttonSaveFile_SAA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SAA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SAA.ShowDialog();

            string path = saveFileDialogMatrix_SAA.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_SAA.RowCount;
            int columns = dataGridViewOutPut_SAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_SAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_SAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }


        private void toolTipButton_SAA_Popup(object sender, PopupEventArgs e)
        {
           
        }

        private void buttonHelp_SAA_Click_1(object sender, EventArgs e)
        {
            toolTipButton_SAA.SetToolTip(buttonHelp_SAA, "Справка");
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_SAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_SAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAA.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_SAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_SAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAA.ToolTipTitle = "Справка";
        }

    }
}

