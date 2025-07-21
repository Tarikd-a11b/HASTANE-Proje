namespace Proje_Hastane
{
    partial class frmHastaGiriş
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTcKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.mskSifre = new System.Windows.Forms.MaskedTextBox();
            this.btnGiriSYap = new System.Windows.Forms.Button();
            this.lbluyeOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tc Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // mskTcKimlikNo
            // 
            this.mskTcKimlikNo.Location = new System.Drawing.Point(183, 100);
            this.mskTcKimlikNo.Mask = "00000000000";
            this.mskTcKimlikNo.Name = "mskTcKimlikNo";
            this.mskTcKimlikNo.Size = new System.Drawing.Size(100, 22);
            this.mskTcKimlikNo.TabIndex = 3;
            this.mskTcKimlikNo.ValidatingType = typeof(int);
            // 
            // mskSifre
            // 
            this.mskSifre.Location = new System.Drawing.Point(183, 136);
            this.mskSifre.Name = "mskSifre";
            this.mskSifre.Size = new System.Drawing.Size(100, 22);
            this.mskSifre.TabIndex = 4;
            // 
            // btnGiriSYap
            // 
            this.btnGiriSYap.Location = new System.Drawing.Point(200, 174);
            this.btnGiriSYap.Name = "btnGiriSYap";
            this.btnGiriSYap.Size = new System.Drawing.Size(83, 28);
            this.btnGiriSYap.TabIndex = 5;
            this.btnGiriSYap.Text = "Giriş Yap";
            this.btnGiriSYap.UseVisualStyleBackColor = true;
            this.btnGiriSYap.Click += new System.EventHandler(this.btnGiriSYap_Click);
            // 
            // lbluyeOl
            // 
            this.lbluyeOl.AutoSize = true;
            this.lbluyeOl.Location = new System.Drawing.Point(329, 142);
            this.lbluyeOl.Name = "lbluyeOl";
            this.lbluyeOl.Size = new System.Drawing.Size(48, 16);
            this.lbluyeOl.TabIndex = 6;
            this.lbluyeOl.TabStop = true;
            this.lbluyeOl.Text = "Üye Ol";
            this.lbluyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbluyeOl_LinkClicked);
            // 
            // frmHastaGiriş
            // 
            this.AcceptButton = this.btnGiriSYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(498, 301);
            this.Controls.Add(this.lbluyeOl);
            this.Controls.Add(this.btnGiriSYap);
            this.Controls.Add(this.mskSifre);
            this.Controls.Add(this.mskTcKimlikNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHastaGiriş";
            this.Text = "HastaGiriş";
            this.Load += new System.EventHandler(this.frmHastaGiriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTcKimlikNo;
        private System.Windows.Forms.MaskedTextBox mskSifre;
        private System.Windows.Forms.Button btnGiriSYap;
        private System.Windows.Forms.LinkLabel lbluyeOl;
    }
}