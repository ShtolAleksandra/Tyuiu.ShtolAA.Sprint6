
namespace Tyuiu.ShtolAA.Sprint6.Task0.V18
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
            this.groupBoxCondition_SAA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_SAA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxCondition2_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_SAA = new System.Windows.Forms.TextBox();
            this.labelVarX_SAA = new System.Windows.Forms.Label();
            this.groupBoxCondition3_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SAA = new System.Windows.Forms.TextBox();
            this.labelVarResult_SAA = new System.Windows.Forms.Label();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.groupBoxCondition_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SAA)).BeginInit();
            this.groupBoxCondition2_SAA.SuspendLayout();
            this.groupBoxCondition3_SAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SAA
            // 
            this.groupBoxCondition_SAA.Controls.Add(this.pictureBoxFormula_SAA);
            this.groupBoxCondition_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxCondition_SAA.Location = new System.Drawing.Point(12, 32);
            this.groupBoxCondition_SAA.Name = "groupBoxCondition_SAA";
            this.groupBoxCondition_SAA.Size = new System.Drawing.Size(776, 250);
            this.groupBoxCondition_SAA.TabIndex = 0;
            this.groupBoxCondition_SAA.TabStop = false;
            this.groupBoxCondition_SAA.Text = "Условие";
            // 
            // pictureBoxFormula_SAA
            // 
            this.pictureBoxFormula_SAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_SAA.Image")));
            this.pictureBoxFormula_SAA.Location = new System.Drawing.Point(575, 31);
            this.pictureBoxFormula_SAA.Name = "pictureBoxFormula_SAA";
            this.pictureBoxFormula_SAA.Size = new System.Drawing.Size(195, 90);
            this.pictureBoxFormula_SAA.TabIndex = 1;
            this.pictureBoxFormula_SAA.TabStop = false;
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.Location = new System.Drawing.Point(6, 31);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(508, 197);
            this.textBoxTask_SAA.TabIndex = 0;
            this.textBoxTask_SAA.Text = "Вычислить выражение по формуле\r\n\r\n";
            // 
            // groupBoxCondition2_SAA
            // 
            this.groupBoxCondition2_SAA.Controls.Add(this.textBoxVarX_SAA);
            this.groupBoxCondition2_SAA.Controls.Add(this.labelVarX_SAA);
            this.groupBoxCondition2_SAA.Location = new System.Drawing.Point(12, 288);
            this.groupBoxCondition2_SAA.Name = "groupBoxCondition2_SAA";
            this.groupBoxCondition2_SAA.Size = new System.Drawing.Size(514, 110);
            this.groupBoxCondition2_SAA.TabIndex = 1;
            this.groupBoxCondition2_SAA.TabStop = false;
            this.groupBoxCondition2_SAA.Text = "Ввод данных";
            // 
            // textBoxVarX_SAA
            // 
            this.textBoxVarX_SAA.Location = new System.Drawing.Point(9, 47);
            this.textBoxVarX_SAA.Name = "textBoxVarX_SAA";
            this.textBoxVarX_SAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarX_SAA.TabIndex = 1;
            this.textBoxVarX_SAA.TextChanged += new System.EventHandler(this.textBoxVarX_SAA_TextChanged);
            this.textBoxVarX_SAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_SAA_KeyPress);
            // 
            // labelVarX_SAA
            // 
            this.labelVarX_SAA.AutoSize = true;
            this.labelVarX_SAA.Location = new System.Drawing.Point(6, 27);
            this.labelVarX_SAA.Name = "labelVarX_SAA";
            this.labelVarX_SAA.Size = new System.Drawing.Size(105, 17);
            this.labelVarX_SAA.TabIndex = 0;
            this.labelVarX_SAA.Text = "Переменная х:";
            this.labelVarX_SAA.Click += new System.EventHandler(this.labelVarX_SAA_Click);
            // 
            // groupBoxCondition3_SAA
            // 
            this.groupBoxCondition3_SAA.Controls.Add(this.textBoxResult_SAA);
            this.groupBoxCondition3_SAA.Controls.Add(this.labelVarResult_SAA);
            this.groupBoxCondition3_SAA.Location = new System.Drawing.Point(532, 288);
            this.groupBoxCondition3_SAA.Name = "groupBoxCondition3_SAA";
            this.groupBoxCondition3_SAA.Size = new System.Drawing.Size(256, 110);
            this.groupBoxCondition3_SAA.TabIndex = 2;
            this.groupBoxCondition3_SAA.TabStop = false;
            this.groupBoxCondition3_SAA.Text = "Вывод данных";
            // 
            // textBoxResult_SAA
            // 
            this.textBoxResult_SAA.Location = new System.Drawing.Point(9, 47);
            this.textBoxResult_SAA.Name = "textBoxResult_SAA";
            this.textBoxResult_SAA.ReadOnly = true;
            this.textBoxResult_SAA.Size = new System.Drawing.Size(124, 22);
            this.textBoxResult_SAA.TabIndex = 1;
            // 
            // labelVarResult_SAA
            // 
            this.labelVarResult_SAA.AutoSize = true;
            this.labelVarResult_SAA.Location = new System.Drawing.Point(6, 27);
            this.labelVarResult_SAA.Name = "labelVarResult_SAA";
            this.labelVarResult_SAA.Size = new System.Drawing.Size(80, 17);
            this.labelVarResult_SAA.TabIndex = 0;
            this.labelVarResult_SAA.Text = "Результат:";
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonDone_SAA.FlatAppearance.BorderSize = 3;
            this.buttonDone_SAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_SAA.Location = new System.Drawing.Point(617, 404);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(171, 34);
            this.buttonDone_SAA.TabIndex = 3;
            this.buttonDone_SAA.Text = "Выполнить ";
            this.buttonDone_SAA.UseVisualStyleBackColor = true;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SAA.Location = new System.Drawing.Point(565, 404);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(37, 33);
            this.buttonHelp_SAA.TabIndex = 4;
            this.buttonHelp_SAA.Text = "?";
            this.buttonHelp_SAA.UseVisualStyleBackColor = true;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 452);
            this.Controls.Add(this.buttonHelp_SAA);
            this.Controls.Add(this.buttonDone_SAA);
            this.Controls.Add(this.groupBoxCondition3_SAA);
            this.Controls.Add(this.groupBoxCondition2_SAA);
            this.Controls.Add(this.groupBoxCondition_SAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6| Таск 0| Вариант 18| Штоль А.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_SAA.ResumeLayout(false);
            this.groupBoxCondition_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SAA)).EndInit();
            this.groupBoxCondition2_SAA.ResumeLayout(false);
            this.groupBoxCondition2_SAA.PerformLayout();
            this.groupBoxCondition3_SAA.ResumeLayout(false);
            this.groupBoxCondition3_SAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SAA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.GroupBox groupBoxCondition2_SAA;
        private System.Windows.Forms.TextBox textBoxVarX_SAA;
        private System.Windows.Forms.Label labelVarX_SAA;
        private System.Windows.Forms.GroupBox groupBoxCondition3_SAA;
        private System.Windows.Forms.TextBox textBoxResult_SAA;
        private System.Windows.Forms.Label labelVarResult_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
    }
}

