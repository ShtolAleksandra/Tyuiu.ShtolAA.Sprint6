
namespace Tyuiu.ShtolAA.Sprint6.Task6.V29
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
            this.groupBoxCondition_SAA = new System.Windows.Forms.GroupBox();
            this.buttonOpenFile_SAA = new System.Windows.Forms.Button();
            this.openFileDialogTask6_SAA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipTask6_SAA = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxCondition_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_SAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_SAA = new System.Windows.Forms.GroupBox();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.textBoxInPut_SAA = new System.Windows.Forms.TextBox();
            this.textBoxOutPut_SAA = new System.Windows.Forms.TextBox();
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.groupBoxCondition_SAA.SuspendLayout();
            this.groupBoxInPut_SAA.SuspendLayout();
            this.groupBoxOutPut_SAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SAA
            // 
            this.groupBoxCondition_SAA.Controls.Add(this.textBoxCondition_SAA);
            this.groupBoxCondition_SAA.Location = new System.Drawing.Point(10, 77);
            this.groupBoxCondition_SAA.Name = "groupBoxCondition_SAA";
            this.groupBoxCondition_SAA.Size = new System.Drawing.Size(829, 113);
            this.groupBoxCondition_SAA.TabIndex = 0;
            this.groupBoxCondition_SAA.TabStop = false;
            this.groupBoxCondition_SAA.Text = "Условие";
            // 
            // buttonOpenFile_SAA
            // 
            this.buttonOpenFile_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SAA.Image")));
            this.buttonOpenFile_SAA.Location = new System.Drawing.Point(10, 12);
            this.buttonOpenFile_SAA.Name = "buttonOpenFile_SAA";
            this.buttonOpenFile_SAA.Size = new System.Drawing.Size(98, 59);
            this.buttonOpenFile_SAA.TabIndex = 1;
            this.toolTipTask6_SAA.SetToolTip(this.buttonOpenFile_SAA, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_SAA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SAA.Click += new System.EventHandler(this.buttonOpenFile_SAA_Click);
            // 
            // openFileDialogTask6_SAA
            // 
            this.openFileDialogTask6_SAA.FileName = "openFileDialog1";
            // 
            // toolTipTask6_SAA
            // 
            this.toolTipTask6_SAA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipTask6_SAA.ToolTipTitle = "Подсказка";
            // 
            // textBoxCondition_SAA
            // 
            this.textBoxCondition_SAA.Location = new System.Drawing.Point(6, 21);
            this.textBoxCondition_SAA.Multiline = true;
            this.textBoxCondition_SAA.Name = "textBoxCondition_SAA";
            this.textBoxCondition_SAA.ReadOnly = true;
            this.textBoxCondition_SAA.Size = new System.Drawing.Size(817, 73);
            this.textBoxCondition_SAA.TabIndex = 0;
            this.textBoxCondition_SAA.Text = resources.GetString("textBoxCondition_SAA.Text");
            // 
            // groupBoxInPut_SAA
            // 
            this.groupBoxInPut_SAA.Controls.Add(this.textBoxInPut_SAA);
            this.groupBoxInPut_SAA.Location = new System.Drawing.Point(10, 196);
            this.groupBoxInPut_SAA.Name = "groupBoxInPut_SAA";
            this.groupBoxInPut_SAA.Size = new System.Drawing.Size(409, 357);
            this.groupBoxInPut_SAA.TabIndex = 2;
            this.groupBoxInPut_SAA.TabStop = false;
            this.groupBoxInPut_SAA.Text = "Ввод";
            // 
            // groupBoxOutPut_SAA
            // 
            this.groupBoxOutPut_SAA.Controls.Add(this.textBoxOutPut_SAA);
            this.groupBoxOutPut_SAA.Location = new System.Drawing.Point(425, 196);
            this.groupBoxOutPut_SAA.Name = "groupBoxOutPut_SAA";
            this.groupBoxOutPut_SAA.Size = new System.Drawing.Size(420, 357);
            this.groupBoxOutPut_SAA.TabIndex = 3;
            this.groupBoxOutPut_SAA.TabStop = false;
            this.groupBoxOutPut_SAA.Text = "Вывод";
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SAA.Image")));
            this.buttonDone_SAA.Location = new System.Drawing.Point(114, 12);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(98, 59);
            this.buttonDone_SAA.TabIndex = 4;
            this.toolTipTask6_SAA.SetToolTip(this.buttonDone_SAA, "Производит поиск в файле вхождений символов и конкатенирует строки в которых нахо" +
        "дятся эти символы\r\n");
            this.buttonDone_SAA.UseVisualStyleBackColor = true;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // textBoxInPut_SAA
            // 
            this.textBoxInPut_SAA.Location = new System.Drawing.Point(6, 76);
            this.textBoxInPut_SAA.Multiline = true;
            this.textBoxInPut_SAA.Name = "textBoxInPut_SAA";
            this.textBoxInPut_SAA.ReadOnly = true;
            this.textBoxInPut_SAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut_SAA.Size = new System.Drawing.Size(397, 275);
            this.textBoxInPut_SAA.TabIndex = 0;
            // 
            // textBoxOutPut_SAA
            // 
            this.textBoxOutPut_SAA.Location = new System.Drawing.Point(6, 21);
            this.textBoxOutPut_SAA.Multiline = true;
            this.textBoxOutPut_SAA.Name = "textBoxOutPut_SAA";
            this.textBoxOutPut_SAA.ReadOnly = true;
            this.textBoxOutPut_SAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_SAA.Size = new System.Drawing.Size(414, 330);
            this.textBoxOutPut_SAA.TabIndex = 0;
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SAA.Image")));
            this.buttonHelp_SAA.Location = new System.Drawing.Point(739, 12);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(106, 59);
            this.buttonHelp_SAA.TabIndex = 5;
            this.toolTipTask6_SAA.SetToolTip(this.buttonHelp_SAA, "Сведения о программе\r\n");
            this.buttonHelp_SAA.UseVisualStyleBackColor = true;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 565);
            this.Controls.Add(this.buttonHelp_SAA);
            this.Controls.Add(this.buttonDone_SAA);
            this.Controls.Add(this.groupBoxOutPut_SAA);
            this.Controls.Add(this.groupBoxInPut_SAA);
            this.Controls.Add(this.buttonOpenFile_SAA);
            this.Controls.Add(this.groupBoxCondition_SAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6| Таск 6| Вариант 29| Штоль А.А.";
            this.groupBoxCondition_SAA.ResumeLayout(false);
            this.groupBoxCondition_SAA.PerformLayout();
            this.groupBoxInPut_SAA.ResumeLayout(false);
            this.groupBoxInPut_SAA.PerformLayout();
            this.groupBoxOutPut_SAA.ResumeLayout(false);
            this.groupBoxOutPut_SAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SAA;
        private System.Windows.Forms.Button buttonOpenFile_SAA;
        private System.Windows.Forms.ToolTip toolTipTask6_SAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask6_SAA;
        private System.Windows.Forms.TextBox textBoxCondition_SAA;
        private System.Windows.Forms.GroupBox groupBoxInPut_SAA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.TextBox textBoxInPut_SAA;
        private System.Windows.Forms.TextBox textBoxOutPut_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
    }
}

