
namespace Tyuiu.ShtolAA.Sprint6.Task4.V6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxCondition_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_SAA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_SAA = new System.Windows.Forms.TextBox();
            this.labelStopStep_SAA = new System.Windows.Forms.Label();
            this.labelStartStep_SAA = new System.Windows.Forms.Label();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.buttonSave_SAA = new System.Windows.Forms.Button();
            this.buttonInfo_SAA = new System.Windows.Forms.Button();
            this.groupBoxOutPut_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SAA = new System.Windows.Forms.TextBox();
            this.chartFunction_SAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCondition_SAA.SuspendLayout();
            this.groupBoxInPut_SAA.SuspendLayout();
            this.groupBoxOutPut_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SAA
            // 
            this.groupBoxCondition_SAA.Controls.Add(this.textBoxCondition_SAA);
            this.groupBoxCondition_SAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_SAA.Name = "groupBoxCondition_SAA";
            this.groupBoxCondition_SAA.Size = new System.Drawing.Size(571, 110);
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
            this.textBoxCondition_SAA.Size = new System.Drawing.Size(562, 83);
            this.textBoxCondition_SAA.TabIndex = 0;
            this.textBoxCondition_SAA.Text = resources.GetString("textBoxCondition_SAA.Text");
            // 
            // groupBoxInPut_SAA
            // 
            this.groupBoxInPut_SAA.Controls.Add(this.textBoxStopStep_SAA);
            this.groupBoxInPut_SAA.Controls.Add(this.textBoxStartStep_SAA);
            this.groupBoxInPut_SAA.Controls.Add(this.labelStopStep_SAA);
            this.groupBoxInPut_SAA.Controls.Add(this.labelStartStep_SAA);
            this.groupBoxInPut_SAA.Location = new System.Drawing.Point(589, 12);
            this.groupBoxInPut_SAA.Name = "groupBoxInPut_SAA";
            this.groupBoxInPut_SAA.Size = new System.Drawing.Size(255, 110);
            this.groupBoxInPut_SAA.TabIndex = 1;
            this.groupBoxInPut_SAA.TabStop = false;
            this.groupBoxInPut_SAA.Text = "Ввод данных";
            // 
            // textBoxStopStep_SAA
            // 
            this.textBoxStopStep_SAA.Location = new System.Drawing.Point(132, 42);
            this.textBoxStopStep_SAA.Name = "textBoxStopStep_SAA";
            this.textBoxStopStep_SAA.Size = new System.Drawing.Size(116, 22);
            this.textBoxStopStep_SAA.TabIndex = 3;
            // 
            // textBoxStartStep_SAA
            // 
            this.textBoxStartStep_SAA.Location = new System.Drawing.Point(10, 42);
            this.textBoxStartStep_SAA.Name = "textBoxStartStep_SAA";
            this.textBoxStartStep_SAA.Size = new System.Drawing.Size(116, 22);
            this.textBoxStartStep_SAA.TabIndex = 2;
            // 
            // labelStopStep_SAA
            // 
            this.labelStopStep_SAA.AutoSize = true;
            this.labelStopStep_SAA.Location = new System.Drawing.Point(129, 22);
            this.labelStopStep_SAA.Name = "labelStopStep_SAA";
            this.labelStopStep_SAA.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_SAA.TabIndex = 1;
            this.labelStopStep_SAA.Text = "Конец шага:";
            this.labelStopStep_SAA.Click += new System.EventHandler(this.labelStopStep_SAA_Click);
            // 
            // labelStartStep_SAA
            // 
            this.labelStartStep_SAA.AutoSize = true;
            this.labelStartStep_SAA.Location = new System.Drawing.Point(7, 22);
            this.labelStartStep_SAA.Name = "labelStartStep_SAA";
            this.labelStartStep_SAA.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_SAA.TabIndex = 0;
            this.labelStartStep_SAA.Text = "Старт шага:";
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_SAA.Location = new System.Drawing.Point(860, 24);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(124, 92);
            this.buttonDone_SAA.TabIndex = 2;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = false;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // buttonSave_SAA
            // 
            this.buttonSave_SAA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_SAA.Location = new System.Drawing.Point(990, 24);
            this.buttonSave_SAA.Name = "buttonSave_SAA";
            this.buttonSave_SAA.Size = new System.Drawing.Size(124, 92);
            this.buttonSave_SAA.TabIndex = 3;
            this.buttonSave_SAA.Text = "Сохранить";
            this.buttonSave_SAA.UseVisualStyleBackColor = false;
            this.buttonSave_SAA.Click += new System.EventHandler(this.buttonSave_SAA_Click);
            // 
            // buttonInfo_SAA
            // 
            this.buttonInfo_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_SAA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_SAA.Location = new System.Drawing.Point(1120, 24);
            this.buttonInfo_SAA.Name = "buttonInfo_SAA";
            this.buttonInfo_SAA.Size = new System.Drawing.Size(124, 92);
            this.buttonInfo_SAA.TabIndex = 4;
            this.buttonInfo_SAA.Text = "Справка";
            this.buttonInfo_SAA.UseVisualStyleBackColor = false;
            this.buttonInfo_SAA.Click += new System.EventHandler(this.buttonInfo_SAA_Click);
            // 
            // groupBoxOutPut_SAA
            // 
            this.groupBoxOutPut_SAA.Controls.Add(this.textBoxResult_SAA);
            this.groupBoxOutPut_SAA.Location = new System.Drawing.Point(12, 128);
            this.groupBoxOutPut_SAA.Name = "groupBoxOutPut_SAA";
            this.groupBoxOutPut_SAA.Size = new System.Drawing.Size(340, 542);
            this.groupBoxOutPut_SAA.TabIndex = 5;
            this.groupBoxOutPut_SAA.TabStop = false;
            this.groupBoxOutPut_SAA.Text = "Вывод данных";
            // 
            // textBoxResult_SAA
            // 
            this.textBoxResult_SAA.Location = new System.Drawing.Point(6, 21);
            this.textBoxResult_SAA.Multiline = true;
            this.textBoxResult_SAA.Name = "textBoxResult_SAA";
            this.textBoxResult_SAA.ReadOnly = true;
            this.textBoxResult_SAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SAA.Size = new System.Drawing.Size(328, 515);
            this.textBoxResult_SAA.TabIndex = 0;
            this.textBoxResult_SAA.TextChanged += new System.EventHandler(this.textBoxResult_SAA_TextChanged);
            // 
            // chartFunction_SAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_SAA.Legends.Add(legend1);
            this.chartFunction_SAA.Location = new System.Drawing.Point(358, 128);
            this.chartFunction_SAA.Name = "chartFunction_SAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SAA.Series.Add(series1);
            this.chartFunction_SAA.Size = new System.Drawing.Size(905, 542);
            this.chartFunction_SAA.TabIndex = 0;
            this.chartFunction_SAA.Text = "chartFunction";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            title1.Name = "TitleCos";
            title1.Text = "График функции F(x)";
            this.chartFunction_SAA.Titles.Add(title1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 682);
            this.Controls.Add(this.chartFunction_SAA);
            this.Controls.Add(this.groupBoxOutPut_SAA);
            this.Controls.Add(this.buttonInfo_SAA);
            this.Controls.Add(this.buttonSave_SAA);
            this.Controls.Add(this.buttonDone_SAA);
            this.Controls.Add(this.groupBoxInPut_SAA);
            this.Controls.Add(this.groupBoxCondition_SAA);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6| Таск 4| Вариант 6|Штоль А.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_SAA.ResumeLayout(false);
            this.groupBoxCondition_SAA.PerformLayout();
            this.groupBoxInPut_SAA.ResumeLayout(false);
            this.groupBoxInPut_SAA.PerformLayout();
            this.groupBoxOutPut_SAA.ResumeLayout(false);
            this.groupBoxOutPut_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SAA;
        private System.Windows.Forms.TextBox textBoxCondition_SAA;
        private System.Windows.Forms.GroupBox groupBoxInPut_SAA;
        private System.Windows.Forms.TextBox textBoxStopStep_SAA;
        private System.Windows.Forms.TextBox textBoxStartStep_SAA;
        private System.Windows.Forms.Label labelStopStep_SAA;
        private System.Windows.Forms.Label labelStartStep_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.Button buttonSave_SAA;
        private System.Windows.Forms.Button buttonInfo_SAA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAA;
        private System.Windows.Forms.TextBox textBoxResult_SAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SAA;
    }
}

