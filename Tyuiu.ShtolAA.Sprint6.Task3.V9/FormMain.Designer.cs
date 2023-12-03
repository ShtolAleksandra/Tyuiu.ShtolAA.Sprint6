
namespace Tyuiu.ShtolAA.Sprint6.Task3.V9
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
            this.groupBoxUslovie_SAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SAA = new System.Windows.Forms.DataGridView();
            this.textBoxUslovie_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxVivod_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SAA = new System.Windows.Forms.TextBox();
            this.labelResult_SAA = new System.Windows.Forms.Label();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.buttonSpravka_SAA = new System.Windows.Forms.Button();
            this.groupBoxUslovie_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAA)).BeginInit();
            this.groupBoxVivod_SAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_SAA
            // 
            this.groupBoxUslovie_SAA.Controls.Add(this.dataGridViewResult_SAA);
            this.groupBoxUslovie_SAA.Controls.Add(this.textBoxUslovie_SAA);
            this.groupBoxUslovie_SAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_SAA.Name = "groupBoxUslovie_SAA";
            this.groupBoxUslovie_SAA.Size = new System.Drawing.Size(703, 351);
            this.groupBoxUslovie_SAA.TabIndex = 0;
            this.groupBoxUslovie_SAA.TabStop = false;
            this.groupBoxUslovie_SAA.Text = "Условие";
            // 
            // dataGridViewResult_SAA
            // 
            this.dataGridViewResult_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SAA.Location = new System.Drawing.Point(358, 31);
            this.dataGridViewResult_SAA.Name = "dataGridViewResult_SAA";
            this.dataGridViewResult_SAA.ReadOnly = true;
            this.dataGridViewResult_SAA.RowHeadersWidth = 51;
            this.dataGridViewResult_SAA.RowTemplate.Height = 24;
            this.dataGridViewResult_SAA.Size = new System.Drawing.Size(321, 298);
            this.dataGridViewResult_SAA.TabIndex = 1;
            this.dataGridViewResult_SAA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrix_SAA_CellContentClick);
            // 
            // textBoxUslovie_SAA
            // 
            this.textBoxUslovie_SAA.Location = new System.Drawing.Point(6, 31);
            this.textBoxUslovie_SAA.Multiline = true;
            this.textBoxUslovie_SAA.Name = "textBoxUslovie_SAA";
            this.textBoxUslovie_SAA.ReadOnly = true;
            this.textBoxUslovie_SAA.Size = new System.Drawing.Size(337, 314);
            this.textBoxUslovie_SAA.TabIndex = 0;
            this.textBoxUslovie_SAA.Text = "Дана матрица 5 на 5\r\n-14  25  26  18  17\r\n  28  10   6  -2   4\r\n  30  25  -3  11 " +
    "-10\r\n  11  32  -5 -20  25\r\n   2 -18  11   8 -20\r\nВыполнить сортировку по возраст" +
    "анию в пятом столбце";
            this.textBoxUslovie_SAA.TextChanged += new System.EventHandler(this.textBoxUslovie_SAA_TextChanged);
            // 
            // groupBoxVivod_SAA
            // 
            this.groupBoxVivod_SAA.Controls.Add(this.textBoxResult_SAA);
            this.groupBoxVivod_SAA.Controls.Add(this.labelResult_SAA);
            this.groupBoxVivod_SAA.Location = new System.Drawing.Point(721, 12);
            this.groupBoxVivod_SAA.Name = "groupBoxVivod_SAA";
            this.groupBoxVivod_SAA.Size = new System.Drawing.Size(198, 140);
            this.groupBoxVivod_SAA.TabIndex = 1;
            this.groupBoxVivod_SAA.TabStop = false;
            this.groupBoxVivod_SAA.Text = "Вывод данных";
            // 
            // textBoxResult_SAA
            // 
            this.textBoxResult_SAA.Location = new System.Drawing.Point(9, 38);
            this.textBoxResult_SAA.Name = "textBoxResult_SAA";
            this.textBoxResult_SAA.ReadOnly = true;
            this.textBoxResult_SAA.Size = new System.Drawing.Size(172, 22);
            this.textBoxResult_SAA.TabIndex = 1;
            this.textBoxResult_SAA.TextChanged += new System.EventHandler(this.textBoxResult_SAA_TextChanged);
            // 
            // labelResult_SAA
            // 
            this.labelResult_SAA.AutoSize = true;
            this.labelResult_SAA.Location = new System.Drawing.Point(6, 18);
            this.labelResult_SAA.Name = "labelResult_SAA";
            this.labelResult_SAA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_SAA.TabIndex = 0;
            this.labelResult_SAA.Text = "Результат:";
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.Location = new System.Drawing.Point(767, 333);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(152, 30);
            this.buttonDone_SAA.TabIndex = 2;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = true;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // buttonSpravka_SAA
            // 
            this.buttonSpravka_SAA.Location = new System.Drawing.Point(730, 333);
            this.buttonSpravka_SAA.Name = "buttonSpravka_SAA";
            this.buttonSpravka_SAA.Size = new System.Drawing.Size(31, 30);
            this.buttonSpravka_SAA.TabIndex = 3;
            this.buttonSpravka_SAA.Text = "?";
            this.buttonSpravka_SAA.UseVisualStyleBackColor = true;
            this.buttonSpravka_SAA.Click += new System.EventHandler(this.buttonSpravka_SAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 375);
            this.Controls.Add(this.buttonSpravka_SAA);
            this.Controls.Add(this.buttonDone_SAA);
            this.Controls.Add(this.groupBoxVivod_SAA);
            this.Controls.Add(this.groupBoxUslovie_SAA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6| Таск 3| Вартант 9| Штоль А.А.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxUslovie_SAA.ResumeLayout(false);
            this.groupBoxUslovie_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAA)).EndInit();
            this.groupBoxVivod_SAA.ResumeLayout(false);
            this.groupBoxVivod_SAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_SAA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SAA;
        private System.Windows.Forms.TextBox textBoxUslovie_SAA;
        private System.Windows.Forms.GroupBox groupBoxVivod_SAA;
        private System.Windows.Forms.TextBox textBoxResult_SAA;
        private System.Windows.Forms.Label labelResult_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.Button buttonSpravka_SAA;
    }
}

