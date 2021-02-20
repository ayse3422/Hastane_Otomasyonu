namespace Hastane_Proje
{
    partial class FrmBilgiGuncelle
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbHastaKayitCinsiyet = new System.Windows.Forms.ComboBox();
            this.mskdHastaKayitTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHastaKayitSoyad = new System.Windows.Forms.TextBox();
            this.txtHastaKyitAd = new System.Windows.Forms.TextBox();
            this.mskdHastaKayitTc = new System.Windows.Forms.MaskedTextBox();
            this.txtHastaKayitSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuncelle.Location = new System.Drawing.Point(200, 382);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(144, 49);
            this.btnGuncelle.TabIndex = 32;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 339);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "CİNSİYET:";
            // 
            // cmbHastaKayitCinsiyet
            // 
            this.cmbHastaKayitCinsiyet.FormattingEnabled = true;
            this.cmbHastaKayitCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cmbHastaKayitCinsiyet.Location = new System.Drawing.Point(165, 329);
            this.cmbHastaKayitCinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHastaKayitCinsiyet.Name = "cmbHastaKayitCinsiyet";
            this.cmbHastaKayitCinsiyet.Size = new System.Drawing.Size(250, 24);
            this.cmbHastaKayitCinsiyet.TabIndex = 6;
            // 
            // mskdHastaKayitTelefon
            // 
            this.mskdHastaKayitTelefon.Location = new System.Drawing.Point(165, 207);
            this.mskdHastaKayitTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.mskdHastaKayitTelefon.Mask = "(999) 000-0000";
            this.mskdHastaKayitTelefon.Name = "mskdHastaKayitTelefon";
            this.mskdHastaKayitTelefon.Size = new System.Drawing.Size(250, 22);
            this.mskdHastaKayitTelefon.TabIndex = 4;
//            this.mskdHastaKayitTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskdHastaKayitTelefon_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "AD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "SOYAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "TELEFON:";
            // 
            // txtHastaKayitSoyad
            // 
            this.txtHastaKayitSoyad.Location = new System.Drawing.Point(165, 79);
            this.txtHastaKayitSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtHastaKayitSoyad.Name = "txtHastaKayitSoyad";
            this.txtHastaKayitSoyad.Size = new System.Drawing.Size(250, 22);
            this.txtHastaKayitSoyad.TabIndex = 2;
            // 
            // txtHastaKyitAd
            // 
            this.txtHastaKyitAd.Location = new System.Drawing.Point(165, 20);
            this.txtHastaKyitAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtHastaKyitAd.Name = "txtHastaKyitAd";
            this.txtHastaKyitAd.Size = new System.Drawing.Size(250, 22);
            this.txtHastaKyitAd.TabIndex = 1;
            // 
            // mskdHastaKayitTc
            // 
            this.mskdHastaKayitTc.Location = new System.Drawing.Point(165, 143);
            this.mskdHastaKayitTc.Margin = new System.Windows.Forms.Padding(4);
            this.mskdHastaKayitTc.Mask = "00000000000";
            this.mskdHastaKayitTc.Name = "mskdHastaKayitTc";
            this.mskdHastaKayitTc.Size = new System.Drawing.Size(250, 22);
            this.mskdHastaKayitTc.TabIndex = 3;
            this.mskdHastaKayitTc.ValidatingType = typeof(int);
          //  this.mskdHastaKayitTc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskdHastaKayitTc_MaskInputRejected);
            // 
            // txtHastaKayitSifre
            // 
            this.txtHastaKayitSifre.Location = new System.Drawing.Point(165, 273);
            this.txtHastaKayitSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtHastaKayitSifre.Name = "txtHastaKayitSifre";
            this.txtHastaKayitSifre.Size = new System.Drawing.Size(250, 22);
            this.txtHastaKayitSifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "ŞİFRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "TC KİMLİK NO:";
            // 
            // FrmBilgiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.btnGuncelle);
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
            this.Name = "FrmBilgiGuncelle";
            this.Text = "FrmBilgiGuncelle";
            this.Load += new System.EventHandler(this.FrmBilgiGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbHastaKayitCinsiyet;
        private System.Windows.Forms.MaskedTextBox mskdHastaKayitTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHastaKayitSoyad;
        private System.Windows.Forms.TextBox txtHastaKyitAd;
        private System.Windows.Forms.MaskedTextBox mskdHastaKayitTc;
        private System.Windows.Forms.TextBox txtHastaKayitSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}