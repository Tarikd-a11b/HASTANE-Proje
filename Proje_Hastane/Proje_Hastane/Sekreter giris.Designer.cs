namespace Proje_Hastane
{
    partial class FrmSekreter
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
            this.btnGiriSYap = new System.Windows.Forms.Button();
            this.mskSifre = new System.Windows.Forms.MaskedTextBox();
            this.mskTcKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiriSYap
            // 
            this.btnGiriSYap.Location = new System.Drawing.Point(218, 199);
            this.btnGiriSYap.Name = "btnGiriSYap";
            this.btnGiriSYap.Size = new System.Drawing.Size(83, 28);
            this.btnGiriSYap.TabIndex = 11;
            this.btnGiriSYap.Text = "Giriş Yap";
            this.btnGiriSYap.UseVisualStyleBackColor = true;
            this.btnGiriSYap.Click += new System.EventHandler(this.btnGiriSYap_Click);
            // 
            // mskSifre
            // 
            this.mskSifre.Location = new System.Drawing.Point(201, 161);
            this.mskSifre.Name = "mskSifre";
            this.mskSifre.Size = new System.Drawing.Size(100, 22);
            this.mskSifre.TabIndex = 10;
            this.mskSifre.UseSystemPasswordChar = true;
            // 
            // mskTcKimlikNo
            // 
            this.mskTcKimlikNo.Location = new System.Drawing.Point(201, 125);
            this.mskTcKimlikNo.Mask = "00000000000";
            this.mskTcKimlikNo.Name = "mskTcKimlikNo";
            this.mskTcKimlikNo.Size = new System.Drawing.Size(100, 22);
            this.mskTcKimlikNo.TabIndex = 9;
            this.mskTcKimlikNo.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tc Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sekreter Giriş Ekranı";
            // 
            // FrmSekreter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(417, 272);
            this.Controls.Add(this.btnGiriSYap);
            this.Controls.Add(this.mskSifre);
            this.Controls.Add(this.mskTcKimlikNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmSekreter";
            this.Text = "FrmSekreter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiriSYap;
        private System.Windows.Forms.MaskedTextBox mskSifre;
        private System.Windows.Forms.MaskedTextBox mskTcKimlikNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}