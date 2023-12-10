
namespace Tyuiu.ShtolAA.Sprint6.Task5.V5
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_SAA = new System.Windows.Forms.TextBox();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.buttonInfo_SAA = new System.Windows.Forms.Button();
            this.groupBoxOutPut_SAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_SAA = new System.Windows.Forms.DataGridView();
            this.chartDiag_SAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonOpenFile_SAA = new System.Windows.Forms.Button();
            this.groupBoxCondition_SAA.SuspendLayout();
            this.groupBoxOutPut_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SAA
            // 
            this.groupBoxCondition_SAA.Controls.Add(this.textBoxCondition_SAA);
            this.groupBoxCondition_SAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_SAA.Name = "groupBoxCondition_SAA";
            this.groupBoxCondition_SAA.Size = new System.Drawing.Size(503, 92);
            this.groupBoxCondition_SAA.TabIndex = 0;
            this.groupBoxCondition_SAA.TabStop = false;
            this.groupBoxCondition_SAA.Text = "Условие";
            // 
            // textBoxCondition_SAA
            // 
            this.textBoxCondition_SAA.Location = new System.Drawing.Point(6, 21);
            this.textBoxCondition_SAA.Multiline = true;
            this.textBoxCondition_SAA.Name = "textBoxCondition_SAA";
            this.textBoxCondition_SAA.ReadOnly = true;
            this.textBoxCondition_SAA.Size = new System.Drawing.Size(492, 65);
            this.textBoxCondition_SAA.TabIndex = 0;
            this.textBoxCondition_SAA.Text = "Прочитать данные из файла InPutFileTask5V5.txt. Вывести в dataGridView. Вывести в" +
    "се числа, кратные 2. Построить диаграмму по этим значениям. \r\n\r\n\r\n\r\n";
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_SAA.Location = new System.Drawing.Point(521, 21);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(117, 77);
            this.buttonDone_SAA.TabIndex = 1;
            this.buttonDone_SAA.Text = "Выполнить ";
            this.buttonDone_SAA.UseVisualStyleBackColor = false;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // buttonInfo_SAA
            // 
            this.buttonInfo_SAA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_SAA.Location = new System.Drawing.Point(767, 21);
            this.buttonInfo_SAA.Name = "buttonInfo_SAA";
            this.buttonInfo_SAA.Size = new System.Drawing.Size(117, 77);
            this.buttonInfo_SAA.TabIndex = 3;
            this.buttonInfo_SAA.Text = "Справка";
            this.buttonInfo_SAA.UseVisualStyleBackColor = false;
            this.buttonInfo_SAA.Click += new System.EventHandler(this.buttonInfo_SAA_Click);
            // 
            // groupBoxOutPut_SAA
            // 
            this.groupBoxOutPut_SAA.Controls.Add(this.dataGridViewOutPut_SAA);
            this.groupBoxOutPut_SAA.Location = new System.Drawing.Point(12, 104);
            this.groupBoxOutPut_SAA.Name = "groupBoxOutPut_SAA";
            this.groupBoxOutPut_SAA.Size = new System.Drawing.Size(178, 454);
            this.groupBoxOutPut_SAA.TabIndex = 4;
            this.groupBoxOutPut_SAA.TabStop = false;
            this.groupBoxOutPut_SAA.Text = "Вывод данных";
            // 
            // dataGridViewOutPut_SAA
            // 
            this.dataGridViewOutPut_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_SAA.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewOutPut_SAA.Name = "dataGridViewOutPut_SAA";
            this.dataGridViewOutPut_SAA.RowHeadersWidth = 51;
            this.dataGridViewOutPut_SAA.RowTemplate.Height = 24;
            this.dataGridViewOutPut_SAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutPut_SAA.Size = new System.Drawing.Size(166, 427);
            this.dataGridViewOutPut_SAA.TabIndex = 0;
            // 
            // chartDiag_SAA
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDiag_SAA.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDiag_SAA.Legends.Add(legend4);
            this.chartDiag_SAA.Location = new System.Drawing.Point(196, 110);
            this.chartDiag_SAA.Name = "chartDiag_SAA";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Green;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDiag_SAA.Series.Add(series4);
            this.chartDiag_SAA.Size = new System.Drawing.Size(695, 448);
            this.chartDiag_SAA.TabIndex = 5;
            this.chartDiag_SAA.Text = "chart1";
            // 
            // buttonOpenFile_SAA
            // 
            this.buttonOpenFile_SAA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpenFile_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_SAA.Location = new System.Drawing.Point(644, 21);
            this.buttonOpenFile_SAA.Name = "buttonOpenFile_SAA";
            this.buttonOpenFile_SAA.Size = new System.Drawing.Size(117, 77);
            this.buttonOpenFile_SAA.TabIndex = 6;
            this.buttonOpenFile_SAA.Text = "Открыть файл";
            this.buttonOpenFile_SAA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_SAA.Click += new System.EventHandler(this.buttonOpenFile_SAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 562);
            this.Controls.Add(this.buttonOpenFile_SAA);
            this.Controls.Add(this.groupBoxOutPut_SAA);
            this.Controls.Add(this.buttonInfo_SAA);
            this.Controls.Add(this.buttonDone_SAA);
            this.Controls.Add(this.groupBoxCondition_SAA);
            this.Controls.Add(this.chartDiag_SAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6| Таск 5| Вариант 5| Штоль А.А.";
            this.groupBoxCondition_SAA.ResumeLayout(false);
            this.groupBoxCondition_SAA.PerformLayout();
            this.groupBoxOutPut_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SAA;
        private System.Windows.Forms.TextBox textBoxCondition_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.Button buttonInfo_SAA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAA;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_SAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_SAA;
        private System.Windows.Forms.Button buttonOpenFile_SAA;
    }
}

