
namespace Tyuiu.ShtolAA.Sprint6.Task6.V29
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_SAA = new System.Windows.Forms.PictureBox();
            this.buttonOk_SAA = new System.Windows.Forms.Button();
            this.textBoxInfo_SAA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_SAA
            // 
            this.pictureBoxAvatar_SAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SAA.Image")));
            this.pictureBoxAvatar_SAA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_SAA.Name = "pictureBoxAvatar_SAA";
            this.pictureBoxAvatar_SAA.Size = new System.Drawing.Size(154, 181);
            this.pictureBoxAvatar_SAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_SAA.TabIndex = 0;
            this.pictureBoxAvatar_SAA.TabStop = false;
            // 
            // buttonOk_SAA
            // 
            this.buttonOk_SAA.Location = new System.Drawing.Point(471, 212);
            this.buttonOk_SAA.Name = "buttonOk_SAA";
            this.buttonOk_SAA.Size = new System.Drawing.Size(96, 27);
            this.buttonOk_SAA.TabIndex = 2;
            this.buttonOk_SAA.Text = "Ок";
            this.buttonOk_SAA.UseVisualStyleBackColor = true;
            this.buttonOk_SAA.Click += new System.EventHandler(this.buttonOk_SAA_Click);
            // 
            // textBoxInfo_SAA
            // 
            this.textBoxInfo_SAA.Location = new System.Drawing.Point(172, 12);
            this.textBoxInfo_SAA.Multiline = true;
            this.textBoxInfo_SAA.Name = "textBoxInfo_SAA";
            this.textBoxInfo_SAA.ReadOnly = true;
            this.textBoxInfo_SAA.Size = new System.Drawing.Size(395, 194);
            this.textBoxInfo_SAA.TabIndex = 3;
            this.textBoxInfo_SAA.Text = resources.GetString("textBoxInfo_SAA.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 241);
            this.Controls.Add(this.textBoxInfo_SAA);
            this.Controls.Add(this.buttonOk_SAA);
            this.Controls.Add(this.pictureBoxAvatar_SAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_SAA;
        private System.Windows.Forms.Button buttonOk_SAA;
        private System.Windows.Forms.TextBox textBoxInfo_SAA;
    }
}