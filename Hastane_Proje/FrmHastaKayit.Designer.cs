namespace Hastane_Proje
{
    partial class FrmHastaKayit
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
            this.mskdHastaKayitTc = new System.Windows.Forms.MaskedTextBox();
            this.txtHastaKayitSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHastaKyitAd = new System.Windows.Forms.TextBox();
            this.txtHastaKayitSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskdHastaKayitTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbHastaKayitCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHastaKayitYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskdHastaKayitTc
            // 
            this.mskdHastaKayitTc.Location = new System.Drawing.Point(216, 168);
            this.mskdHastaKayitTc.Margin = new System.Windows.Forms.Padding(4);
            this.mskdHastaKayitTc.Mask = "00000000000";
            this.mskdHastaKayitTc.Name = "mskdHastaKayitTc";
            this.mskdHastaKayitTc.Size = new System.Drawing.Size(250, 32);
            this.mskdHastaKayitTc.TabIndex = 3;
            this.mskdHastaKayitTc.ValidatingType = typeof(int);
            // 
            // txtHastaKayitSifre
            // 
            this.txtHastaKayitSifre.Location = new System.Drawing.Point(216, 298);
            this.txtHastaKayitSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtHastaKayitSifre.Name = "txtHastaKayitSifre";
            this.txtHastaKayitSifre.Size = new System.Drawing.Size(250, 32);
            this.txtHastaKayitSifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "ŞİFRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "TC KİMLİK NO:";
            // 
            // txtHastaKyitAd
            // 
            this.txtHastaKyitAd.Location = new System.Drawing.Point(216, 45);
            this.txtHastaKyitAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtHastaKyitAd.Name = "txtHastaKyitAd";
            this.txtHastaKyitAd.Size = new System.Drawing.Size(250, 32);
            this.txtHastaKyitAd.TabIndex = 1;
            // 
            // txtHastaKayitSoyad
            // 
            this.txtHastaKayitSoyad.Location = new System.Drawing.Point(216, 104);
            this.txtHastaKayitSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtHastaKayitSoyad.Name = "txtHastaKayitSoyad";
            this.txtHastaKayitSoyad.Size = new System.Drawing.Size(250, 32);
            this.txtHastaKayitSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "TELEFON:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "SOYAD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "AD:";
            // 
            // mskdHastaKayitTelefon
            // 
            this.mskdHastaKayitTelefon.Location = new System.Drawing.Point(216, 232);
            this.mskdHastaKayitTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.mskdHastaKayitTelefon.Mask = "(999) 000-0000";
            this.mskdHastaKayitTelefon.Name = "mskdHastaKayitTelefon";
            this.mskdHastaKayitTelefon.Size = new System.Drawing.Size(250, 32);
            this.mskdHastaKayitTelefon.TabIndex = 4;
            this.mskdHastaKayitTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskdHastaKayitTelefon_MaskInputRejected);
            // 
            // cmbHastaKayitCinsiyet
            // 
            this.cmbHastaKayitCinsiyet.FormattingEnabled = true;
            this.cmbHastaKayitCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cmbHastaKayitCinsiyet.Location = new System.Drawing.Point(216, 354);
            this.cmbHastaKayitCinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHastaKayitCinsiyet.Name = "cmbHastaKayitCinsiyet";
            this.cmbHastaKayitCinsiyet.Size = new System.Drawing.Size(250, 32);
            this.cmbHastaKayitCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 364);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "CİNSİYET:";
            // 
            // btnHastaKayitYap
            // 
            this.btnHastaKayitYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHastaKayitYap.Location = new System.Drawing.Point(251, 407);
            this.btnHastaKayitYap.Name = "btnHastaKayitYap";
            this.btnHastaKayitYap.Size = new System.Drawing.Size(144, 49);
            this.btnHastaKayitYap.TabIndex = 19;
            this.btnHastaKayitYap.Text = "KAYIT YAP";
            this.btnHastaKayitYap.UseVisualStyleBackColor = false;
            this.btnHastaKayitYap.Click += new System.EventHandler(this.btnHastaKayitYap_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btnHastaKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(567, 494);
            this.Controls.Add(this.btnHastaKayitYap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbHastaKayitCinsiyet);
            this.Controls.Add(this.mskdHastaKayitTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHastaKayitSoyad);
            this.Controls.Add(this.txtHastaKyitAd);
            this.Controls.Add(this.mskdHastaKayitTc);
            this.Controls.Add(this.txtHastaKayitSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "FrmHastaKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskdHastaKayitTc;
        private System.Windows.Forms.TextBox txtHastaKayitSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHastaKyitAd;
        private System.Windows.Forms.TextBox txtHastaKayitSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskdHastaKayitTelefon;
        private System.Windows.Forms.ComboBox cmbHastaKayitCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHastaKayitYap;
    }
}