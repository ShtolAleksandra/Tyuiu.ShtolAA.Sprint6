
namespace Tyuiu.ShtolAA.Sprint6.Task7.V26
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonOpenFile_SAA = new System.Windows.Forms.Button();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.buttonSaveFile_SAA = new System.Windows.Forms.Button();
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.groupBoxCondition_SAA = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_SAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_SAA = new System.Windows.Forms.DataGridView();
            this.groupBoxOutPut_SAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_SAA = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask7_SAA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_SAA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_SAA = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxCondition_SAA.SuspendLayout();
            this.groupBoxInPut_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_SAA)).BeginInit();
            this.groupBoxOutPut_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenFile_SAA
            // 
            this.buttonOpenFile_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SAA.Image")));
            this.buttonOpenFile_SAA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_SAA.Name = "buttonOpenFile_SAA";
            this.buttonOpenFile_SAA.Size = new System.Drawing.Size(101, 75);
            this.buttonOpenFile_SAA.TabIndex = 0;
            this.toolTipButton_SAA.SetToolTip(this.buttonOpenFile_SAA, "Открыть файл для обработки данных в формате CSV\r\n");
            this.buttonOpenFile_SAA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SAA.Click += new System.EventHandler(this.buttonOpenFile_SAA_Click);
            this.buttonOpenFile_SAA.MouseEnter += new System.EventHandler(this.buttonOpenFile_SAA_MouseEnter);
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_SAA.Enabled = false;
            this.buttonDone_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SAA.Image")));
            this.buttonDone_SAA.Location = new System.Drawing.Point(119, 12);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(101, 75);
            this.buttonDone_SAA.TabIndex = 1;
            this.toolTipButton_SAA.SetToolTip(this.buttonDone_SAA, "Выполнить обработку данных");
            this.buttonDone_SAA.UseVisualStyleBackColor = true;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            this.buttonDone_SAA.MouseEnter += new System.EventHandler(this.buttonDone_SAA_MouseEnter);
            // 
            // buttonSaveFile_SAA
            // 
            this.buttonSaveFile_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveFile_SAA.Enabled = false;
            this.buttonSaveFile_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_SAA.Image")));
            this.buttonSaveFile_SAA.Location = new System.Drawing.Point(226, 12);
            this.buttonSaveFile_SAA.Name = "buttonSaveFile_SAA";
            this.buttonSaveFile_SAA.Size = new System.Drawing.Size(102, 75);
            this.buttonSaveFile_SAA.TabIndex = 2;
            this.toolTipButton_SAA.SetToolTip(this.buttonSaveFile_SAA, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSaveFile_SAA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_SAA.Click += new System.EventHandler(this.buttonSaveFile_SAA_Click);
            this.buttonSaveFile_SAA.MouseEnter += new System.EventHandler(this.buttonSaveFile_SAA_MouseEnter);
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SAA.Image")));
            this.buttonHelp_SAA.Location = new System.Drawing.Point(875, 12);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(102, 75);
            this.buttonHelp_SAA.TabIndex = 3;
            this.toolTipButton_SAA.SetToolTip(this.buttonHelp_SAA, "Сведения о программе\r\n");
            this.buttonHelp_SAA.UseVisualStyleBackColor = true;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click_1);
            this.buttonHelp_SAA.MouseEnter += new System.EventHandler(this.buttonHelp_SAA_MouseEnter);
            // 
            // groupBoxCondition_SAA
            // 
            this.groupBoxCondition_SAA.Controls.Add(this.textBox1);
            this.groupBoxCondition_SAA.Location = new System.Drawing.Point(12, 93);
            this.groupBoxCondition_SAA.Name = "groupBoxCondition_SAA";
            this.groupBoxCondition_SAA.Size = new System.Drawing.Size(965, 100);
            this.groupBoxCondition_SAA.TabIndex = 4;
            this.groupBoxCondition_SAA.TabStop = false;
            this.groupBoxCondition_SAA.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(953, 73);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxInPut_SAA
            // 
            this.groupBoxInPut_SAA.Controls.Add(this.dataGridViewInPut_SAA);
            this.groupBoxInPut_SAA.Location = new System.Drawing.Point(12, 199);
            this.groupBoxInPut_SAA.Name = "groupBoxInPut_SAA";
            this.groupBoxInPut_SAA.Size = new System.Drawing.Size(464, 297);
            this.groupBoxInPut_SAA.TabIndex = 5;
            this.groupBoxInPut_SAA.TabStop = false;
            this.groupBoxInPut_SAA.Text = "Ввод";
            // 
            // dataGridViewInPut_SAA
            // 
            this.dataGridViewInPut_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_SAA.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewInPut_SAA.Name = "dataGridViewInPut_SAA";
            this.dataGridViewInPut_SAA.RowHeadersWidth = 51;
            this.dataGridViewInPut_SAA.RowTemplate.Height = 24;
            this.dataGridViewInPut_SAA.Size = new System.Drawing.Size(452, 271);
            this.dataGridViewInPut_SAA.TabIndex = 0;
            // 
            // groupBoxOutPut_SAA
            // 
            this.groupBoxOutPut_SAA.Controls.Add(this.dataGridViewOutPut_SAA);
            this.groupBoxOutPut_SAA.Location = new System.Drawing.Point(482, 199);
            this.groupBoxOutPut_SAA.Name = "groupBoxOutPut_SAA";
            this.groupBoxOutPut_SAA.Size = new System.Drawing.Size(495, 297);
            this.groupBoxOutPut_SAA.TabIndex = 6;
            this.groupBoxOutPut_SAA.TabStop = false;
            this.groupBoxOutPut_SAA.Text = "Вывод";
            // 
            // dataGridViewOutPut_SAA
            // 
            this.dataGridViewOutPut_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_SAA.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewOutPut_SAA.Name = "dataGridViewOutPut_SAA";
            this.dataGridViewOutPut_SAA.RowHeadersWidth = 51;
            this.dataGridViewOutPut_SAA.RowTemplate.Height = 24;
            this.dataGridViewOutPut_SAA.Size = new System.Drawing.Size(483, 270);
            this.dataGridViewOutPut_SAA.TabIndex = 0;
            // 
            // openFileDialogTask7_SAA
            // 
            this.openFileDialogTask7_SAA.FileName = "openFileDialog1";
            // 
            // toolTipButton_SAA
            // 
            this.toolTipButton_SAA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_SAA.ToolTipTitle = "Подсказка";
            this.toolTipButton_SAA.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipButton_SAA_Popup);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 508);
            this.Controls.Add(this.groupBoxOutPut_SAA);
            this.Controls.Add(this.groupBoxInPut_SAA);
            this.Controls.Add(this.groupBoxCondition_SAA);
            this.Controls.Add(this.buttonHelp_SAA);
            this.Controls.Add(this.buttonSaveFile_SAA);
            this.Controls.Add(this.buttonDone_SAA);
            this.Controls.Add(this.buttonOpenFile_SAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6| Таск 7| Вариант 26| Штоль А.А. ";
            this.groupBoxCondition_SAA.ResumeLayout(false);
            this.groupBoxCondition_SAA.PerformLayout();
            this.groupBoxInPut_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_SAA)).EndInit();
            this.groupBoxOutPut_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.Button buttonSaveFile_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
        private System.Windows.Forms.GroupBox groupBoxCondition_SAA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxInPut_SAA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask7_SAA;
        private System.Windows.Forms.ToolTip toolTipButton_SAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SAA;
        private System.Windows.Forms.DataGridView dataGridViewInPut_SAA;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_SAA;
    }
}

