
namespace Tyuiu.ShtolAA.Sprint6.Task1.V12
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
            this.textBoxUslovie_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxVvod_SAA = new System.Windows.Forms.GroupBox();
            this.labelStart_SAA = new System.Windows.Forms.Label();
            this.labelKonec_SAA = new System.Windows.Forms.Label();
            this.textBoxStart_SAA = new System.Windows.Forms.TextBox();
            this.textBoxKonec_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxVivod_SAA = new System.Windows.Forms.GroupBox();
            this.labelResult_SAA = new System.Windows.Forms.Label();
            this.buttonSpravka_SAA = new System.Windows.Forms.Button();
            this.buttonVip_SAA = new System.Windows.Forms.Button();
            this.textBoxResult_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxUslovie_SAA.SuspendLayout();
            this.groupBoxVvod_SAA.SuspendLayout();
            this.groupBoxVivod_SAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_SAA
            // 
            this.groupBoxUslovie_SAA.Controls.Add(this.textBoxUslovie_SAA);
            this.groupBoxUslovie_SAA.Location = new System.Drawing.Point(12, 25);
            this.groupBoxUslovie_SAA.Name = "groupBoxUslovie_SAA";
            this.groupBoxUslovie_SAA.Size = new System.Drawing.Size(519, 304);
            this.groupBoxUslovie_SAA.TabIndex = 0;
            this.groupBoxUslovie_SAA.TabStop = false;
            this.groupBoxUslovie_SAA.Text = "Условие";
            // 
            // textBoxUslovie_SAA
            // 
            this.textBoxUslovie_SAA.Location = new System.Drawing.Point(6, 21);
            this.textBoxUslovie_SAA.Multiline = true;
            this.textBoxUslovie_SAA.Name = "textBoxUslovie_SAA";
            this.textBoxUslovie_SAA.ReadOnly = true;
            this.textBoxUslovie_SAA.Size = new System.Drawing.Size(495, 264);
            this.textBoxUslovie_SAA.TabIndex = 0;
            this.textBoxUslovie_SAA.Text = "Протабулировать функцию sin(x) + ((cos(x)+1)/2-x)+2*x на заданном диапазоне.  Рез" +
    "ультат вывести в виде таблицы.";
            // 
            // groupBoxVvod_SAA
            // 
            this.groupBoxVvod_SAA.Controls.Add(this.textBoxKonec_SAA);
            this.groupBoxVvod_SAA.Controls.Add(this.textBoxStart_SAA);
            this.groupBoxVvod_SAA.Controls.Add(this.labelKonec_SAA);
            this.groupBoxVvod_SAA.Controls.Add(this.labelStart_SAA);
            this.groupBoxVvod_SAA.Location = new System.Drawing.Point(12, 344);
            this.groupBoxVvod_SAA.Name = "groupBoxVvod_SAA";
            this.groupBoxVvod_SAA.Size = new System.Drawing.Size(284, 94);
            this.groupBoxVvod_SAA.TabIndex = 1;
            this.groupBoxVvod_SAA.TabStop = false;
            this.groupBoxVvod_SAA.Text = "Ввод данных";
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
            // labelKonec_SAA
            // 
            this.labelKonec_SAA.AutoSize = true;
            this.labelKonec_SAA.Location = new System.Drawing.Point(161, 22);
            this.labelKonec_SAA.Name = "labelKonec_SAA";
            this.labelKonec_SAA.Size = new System.Drawing.Size(89, 17);
            this.labelKonec_SAA.TabIndex = 1;
            this.labelKonec_SAA.Text = "Конец шага:";
            // 
            // textBoxStart_SAA
            // 
            this.textBoxStart_SAA.Location = new System.Drawing.Point(10, 43);
            this.textBoxStart_SAA.Name = "textBoxStart_SAA";
            this.textBoxStart_SAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_SAA.TabIndex = 2;
            // 
            // textBoxKonec_SAA
            // 
            this.textBoxKonec_SAA.Location = new System.Drawing.Point(164, 43);
            this.textBoxKonec_SAA.Name = "textBoxKonec_SAA";
            this.textBoxKonec_SAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxKonec_SAA.TabIndex = 3;
            // 
            // groupBoxVivod_SAA
            // 
            this.groupBoxVivod_SAA.Controls.Add(this.textBoxResult_SAA);
            this.groupBoxVivod_SAA.Controls.Add(this.labelResult_SAA);
            this.groupBoxVivod_SAA.Location = new System.Drawing.Point(536, 25);
            this.groupBoxVivod_SAA.Name = "groupBoxVivod_SAA";
            this.groupBoxVivod_SAA.Size = new System.Drawing.Size(303, 406);
            this.groupBoxVivod_SAA.TabIndex = 2;
            this.groupBoxVivod_SAA.TabStop = false;
            this.groupBoxVivod_SAA.Text = "Вывод данных";
            // 
            // labelResult_SAA
            // 
            this.labelResult_SAA.AutoSize = true;
            this.labelResult_SAA.Location = new System.Drawing.Point(7, 22);
            this.labelResult_SAA.Name = "labelResult_SAA";
            this.labelResult_SAA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_SAA.TabIndex = 0;
            this.labelResult_SAA.Text = "Результат:";
            // 
            // buttonSpravka_SAA
            // 
            this.buttonSpravka_SAA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSpravka_SAA.ForeColor = System.Drawing.Color.Black;
            this.buttonSpravka_SAA.Location = new System.Drawing.Point(302, 351);
            this.buttonSpravka_SAA.Name = "buttonSpravka_SAA";
            this.buttonSpravka_SAA.Size = new System.Drawing.Size(91, 87);
            this.buttonSpravka_SAA.TabIndex = 3;
            this.buttonSpravka_SAA.Text = "Справка";
            this.buttonSpravka_SAA.UseVisualStyleBackColor = false;
            this.buttonSpravka_SAA.Click += new System.EventHandler(this.buttonSpravka_SAA_Click);
            // 
            // buttonVip_SAA
            // 
            this.buttonVip_SAA.BackColor = System.Drawing.Color.Green;
            this.buttonVip_SAA.Location = new System.Drawing.Point(399, 351);
            this.buttonVip_SAA.Name = "buttonVip_SAA";
            this.buttonVip_SAA.Size = new System.Drawing.Size(131, 87);
            this.buttonVip_SAA.TabIndex = 4;
            this.buttonVip_SAA.Text = "Выполнить";
            this.buttonVip_SAA.UseVisualStyleBackColor = false;
            this.buttonVip_SAA.Click += new System.EventHandler(this.buttonVip_SAA_Click);
            // 
            // textBoxResult_SAA
            // 
            this.textBoxResult_SAA.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxResult_SAA.Location = new System.Drawing.Point(0, 42);
            this.textBoxResult_SAA.Multiline = true;
            this.textBoxResult_SAA.Name = "textBoxResult_SAA";
            this.textBoxResult_SAA.ReadOnly = true;
            this.textBoxResult_SAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SAA.Size = new System.Drawing.Size(297, 358);
            this.textBoxResult_SAA.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 443);
            this.Controls.Add(this.buttonVip_SAA);
            this.Controls.Add(this.buttonSpravka_SAA);
            this.Controls.Add(this.groupBoxVivod_SAA);
            this.Controls.Add(this.groupBoxVvod_SAA);
            this.Controls.Add(this.groupBoxUslovie_SAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6| Таск1| Вариант 12| Штоль А.А.";
            this.groupBoxUslovie_SAA.ResumeLayout(false);
            this.groupBoxUslovie_SAA.PerformLayout();
            this.groupBoxVvod_SAA.ResumeLayout(false);
            this.groupBoxVvod_SAA.PerformLayout();
            this.groupBoxVivod_SAA.ResumeLayout(false);
            this.groupBoxVivod_SAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_SAA;
        private System.Windows.Forms.TextBox textBoxUslovie_SAA;
        private System.Windows.Forms.GroupBox groupBoxVvod_SAA;
        private System.Windows.Forms.TextBox textBoxKonec_SAA;
        private System.Windows.Forms.TextBox textBoxStart_SAA;
        private System.Windows.Forms.Label labelKonec_SAA;
        private System.Windows.Forms.Label labelStart_SAA;
        private System.Windows.Forms.GroupBox groupBoxVivod_SAA;
        private System.Windows.Forms.Label labelResult_SAA;
        private System.Windows.Forms.Button buttonSpravka_SAA;
        private System.Windows.Forms.Button buttonVip_SAA;
        private System.Windows.Forms.TextBox textBoxResult_SAA;
    }
}

