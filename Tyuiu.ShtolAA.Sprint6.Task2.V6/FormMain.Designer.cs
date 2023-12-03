
namespace Tyuiu.ShtolAA.Sprint6.Task2.V6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxUslovie_SAA = new System.Windows.Forms.GroupBox();
            this.labelUslovie_SAA = new System.Windows.Forms.Label();
            this.textBoxUslovie_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxVVod_SAA = new System.Windows.Forms.GroupBox();
            this.labelStart_SAA = new System.Windows.Forms.Label();
            this.labelStop_SAA = new System.Windows.Forms.Label();
            this.textBoxStart_SAA = new System.Windows.Forms.TextBox();
            this.textBoxStop_SAA = new System.Windows.Forms.TextBox();
            this.buttonSpravka_SAA = new System.Windows.Forms.Button();
            this.buttonVip_SAA = new System.Windows.Forms.Button();
            this.groupBoxVivod_SAA = new System.Windows.Forms.GroupBox();
            this.labelResult_SAA = new System.Windows.Forms.Label();
            this.dataGridViewFunction_SAA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_SAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxUslovie_SAA.SuspendLayout();
            this.groupBoxVVod_SAA.SuspendLayout();
            this.groupBoxVivod_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_SAA
            // 
            this.groupBoxUslovie_SAA.Controls.Add(this.textBoxUslovie_SAA);
            this.groupBoxUslovie_SAA.Controls.Add(this.labelUslovie_SAA);
            this.groupBoxUslovie_SAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_SAA.Name = "groupBoxUslovie_SAA";
            this.groupBoxUslovie_SAA.Size = new System.Drawing.Size(569, 342);
            this.groupBoxUslovie_SAA.TabIndex = 0;
            this.groupBoxUslovie_SAA.TabStop = false;
            this.groupBoxUslovie_SAA.Text = "Условие";
            // 
            // labelUslovie_SAA
            // 
            this.labelUslovie_SAA.AutoSize = true;
            this.labelUslovie_SAA.Location = new System.Drawing.Point(75, 58);
            this.labelUslovie_SAA.Name = "labelUslovie_SAA";
            this.labelUslovie_SAA.Size = new System.Drawing.Size(8, 34);
            this.labelUslovie_SAA.TabIndex = 0;
            this.labelUslovie_SAA.Text = "\r\n\r\n";
            // 
            // textBoxUslovie_SAA
            // 
            this.textBoxUslovie_SAA.Location = new System.Drawing.Point(6, 21);
            this.textBoxUslovie_SAA.Multiline = true;
            this.textBoxUslovie_SAA.Name = "textBoxUslovie_SAA";
            this.textBoxUslovie_SAA.ReadOnly = true;
            this.textBoxUslovie_SAA.Size = new System.Drawing.Size(557, 315);
            this.textBoxUslovie_SAA.TabIndex = 1;
            this.textBoxUslovie_SAA.Text = " Протабулировать функцию cos(x))/(x-0.7))-sin(x)*12*x+2 на заданном диапазоне. Ре" +
    "зультат вывести  в DataGridView и построить график функции.";
            // 
            // groupBoxVVod_SAA
            // 
            this.groupBoxVVod_SAA.Controls.Add(this.textBoxStop_SAA);
            this.groupBoxVVod_SAA.Controls.Add(this.textBoxStart_SAA);
            this.groupBoxVVod_SAA.Controls.Add(this.labelStop_SAA);
            this.groupBoxVVod_SAA.Controls.Add(this.labelStart_SAA);
            this.groupBoxVVod_SAA.Location = new System.Drawing.Point(18, 360);
            this.groupBoxVVod_SAA.Name = "groupBoxVVod_SAA";
            this.groupBoxVVod_SAA.Size = new System.Drawing.Size(304, 78);
            this.groupBoxVVod_SAA.TabIndex = 1;
            this.groupBoxVVod_SAA.TabStop = false;
            this.groupBoxVVod_SAA.Text = "Ввод данных";
            // 
            // labelStart_SAA
            // 
            this.labelStart_SAA.AutoSize = true;
            this.labelStart_SAA.Location = new System.Drawing.Point(7, 22);
            this.labelStart_SAA.Name = "labelStart_SAA";
            this.labelStart_SAA.Size = new System.Drawing.Size(87, 17);
            this.labelStart_SAA.TabIndex = 0;
            this.labelStart_SAA.Text = "Старт шага:";
            // 
            // labelStop_SAA
            // 
            this.labelStop_SAA.AutoSize = true;
            this.labelStop_SAA.Location = new System.Drawing.Point(176, 22);
            this.labelStop_SAA.Name = "labelStop_SAA";
            this.labelStop_SAA.Size = new System.Drawing.Size(89, 17);
            this.labelStop_SAA.TabIndex = 1;
            this.labelStop_SAA.Text = "Конец шага:";
            // 
            // textBoxStart_SAA
            // 
            this.textBoxStart_SAA.Location = new System.Drawing.Point(10, 43);
            this.textBoxStart_SAA.Name = "textBoxStart_SAA";
            this.textBoxStart_SAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_SAA.TabIndex = 2;
            // 
            // textBoxStop_SAA
            // 
            this.textBoxStop_SAA.Location = new System.Drawing.Point(179, 43);
            this.textBoxStop_SAA.Name = "textBoxStop_SAA";
            this.textBoxStop_SAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop_SAA.TabIndex = 3;
            // 
            // buttonSpravka_SAA
            // 
            this.buttonSpravka_SAA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSpravka_SAA.Location = new System.Drawing.Point(328, 360);
            this.buttonSpravka_SAA.Name = "buttonSpravka_SAA";
            this.buttonSpravka_SAA.Size = new System.Drawing.Size(110, 77);
            this.buttonSpravka_SAA.TabIndex = 2;
            this.buttonSpravka_SAA.Text = "Справка";
            this.buttonSpravka_SAA.UseVisualStyleBackColor = false;
            this.buttonSpravka_SAA.Click += new System.EventHandler(this.buttonSpravka_SAA_Click);
            // 
            // buttonVip_SAA
            // 
            this.buttonVip_SAA.BackColor = System.Drawing.Color.Green;
            this.buttonVip_SAA.Location = new System.Drawing.Point(444, 360);
            this.buttonVip_SAA.Name = "buttonVip_SAA";
            this.buttonVip_SAA.Size = new System.Drawing.Size(137, 77);
            this.buttonVip_SAA.TabIndex = 3;
            this.buttonVip_SAA.Text = "Выполнить";
            this.buttonVip_SAA.UseVisualStyleBackColor = false;
            this.buttonVip_SAA.Click += new System.EventHandler(this.buttonVip_SAA_Click);
            this.buttonVip_SAA.MouseEnter += new System.EventHandler(this.buttonVip_SAA_MouseEnter);
            this.buttonVip_SAA.MouseLeave += new System.EventHandler(this.buttonVip_SAA_MouseLeave);
            // 
            // groupBoxVivod_SAA
            // 
            this.groupBoxVivod_SAA.Controls.Add(this.chartFunction_SAA);
            this.groupBoxVivod_SAA.Controls.Add(this.dataGridViewFunction_SAA);
            this.groupBoxVivod_SAA.Controls.Add(this.labelResult_SAA);
            this.groupBoxVivod_SAA.Location = new System.Drawing.Point(587, 12);
            this.groupBoxVivod_SAA.Name = "groupBoxVivod_SAA";
            this.groupBoxVivod_SAA.Size = new System.Drawing.Size(693, 433);
            this.groupBoxVivod_SAA.TabIndex = 4;
            this.groupBoxVivod_SAA.TabStop = false;
            this.groupBoxVivod_SAA.Text = "Вывод данных";
            // 
            // labelResult_SAA
            // 
            this.labelResult_SAA.AutoSize = true;
            this.labelResult_SAA.Location = new System.Drawing.Point(6, 21);
            this.labelResult_SAA.Name = "labelResult_SAA";
            this.labelResult_SAA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_SAA.TabIndex = 0;
            this.labelResult_SAA.Text = "Результат:";
            // 
            // dataGridViewFunction_SAA
            // 
            this.dataGridViewFunction_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_SAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_SAA.Location = new System.Drawing.Point(9, 41);
            this.dataGridViewFunction_SAA.Name = "dataGridViewFunction_SAA";
            this.dataGridViewFunction_SAA.RowHeadersVisible = false;
            this.dataGridViewFunction_SAA.RowHeadersWidth = 51;
            this.dataGridViewFunction_SAA.RowTemplate.Height = 24;
            this.dataGridViewFunction_SAA.Size = new System.Drawing.Size(156, 384);
            this.dataGridViewFunction_SAA.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(x)";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // chartFunction_SAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_SAA.Legends.Add(legend1);
            this.chartFunction_SAA.Location = new System.Drawing.Point(171, 41);
            this.chartFunction_SAA.Name = "chartFunction_SAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SAA.Series.Add(series1);
            this.chartFunction_SAA.Size = new System.Drawing.Size(516, 386);
            this.chartFunction_SAA.TabIndex = 2;
            this.chartFunction_SAA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 450);
            this.Controls.Add(this.groupBoxVivod_SAA);
            this.Controls.Add(this.buttonVip_SAA);
            this.Controls.Add(this.buttonSpravka_SAA);
            this.Controls.Add(this.groupBoxVVod_SAA);
            this.Controls.Add(this.groupBoxUslovie_SAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6| Таск 2| Вариант 6| Штоль А.А.";
            this.groupBoxUslovie_SAA.ResumeLayout(false);
            this.groupBoxUslovie_SAA.PerformLayout();
            this.groupBoxVVod_SAA.ResumeLayout(false);
            this.groupBoxVVod_SAA.PerformLayout();
            this.groupBoxVivod_SAA.ResumeLayout(false);
            this.groupBoxVivod_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_SAA;
        private System.Windows.Forms.TextBox textBoxUslovie_SAA;
        private System.Windows.Forms.Label labelUslovie_SAA;
        private System.Windows.Forms.GroupBox groupBoxVVod_SAA;
        private System.Windows.Forms.TextBox textBoxStop_SAA;
        private System.Windows.Forms.TextBox textBoxStart_SAA;
        private System.Windows.Forms.Label labelStop_SAA;
        private System.Windows.Forms.Label labelStart_SAA;
        private System.Windows.Forms.Button buttonSpravka_SAA;
        private System.Windows.Forms.Button buttonVip_SAA;
        private System.Windows.Forms.GroupBox groupBoxVivod_SAA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_SAA;
        private System.Windows.Forms.Label labelResult_SAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SAA;
    }
}

