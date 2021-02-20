namespace Hastane_Proje
{
    partial class FrmDoktorBilgiDuzenle
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoktorKayitSoyad = new System.Windows.Forms.TextBox();
            this.txtDoktorKyitAd = new System.Windows.Forms.TextBox();
            this.mskdDoktorKayitTc = new System.Windows.Forms.MaskedTextBox();
            this.txtDoktorKayitSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.btnDoktorGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 29);
            this.label5.TabIndex = 36;
            this.label5.Text = "AD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "SOYAD:";
            // 
            // txtDoktorKayitSoyad
            // 
            this.txtDoktorKayitSoyad.Location = new System.Drawing.Point(202, 98);
            this.txtDoktorKayitSoyad.Margin = new System.Windows.Forms.Padding(7);
            this.txtDoktorKayitSoyad.Name = "txtDoktorKayitSoyad";
            this.txtDoktorKayitSoyad.Size = new System.Drawing.Size(211, 34);
            this.txtDoktorKayitSoyad.TabIndex = 34;
            // 
            // txtDoktorKyitAd
            // 
            this.txtDoktorKyitAd.Location = new System.Drawing.Point(202, 42);
            this.txtDoktorKyitAd.Margin = new System.Windows.Forms.Padding(7);
            this.txtDoktorKyitAd.Name = "txtDoktorKyitAd";
            this.txtDoktorKyitAd.Size = new System.Drawing.Size(211, 34);
            this.txtDoktorKyitAd.TabIndex = 33;
            // 
            // mskdDoktorKayitTc
            // 
            this.mskdDoktorKayitTc.Location = new System.Drawing.Point(202, 163);
            this.mskdDoktorKayitTc.Margin = new System.Windows.Forms.Padding(7);
            this.mskdDoktorKayitTc.Mask = "00000000000";
            this.mskdDoktorKayitTc.Name = "mskdDoktorKayitTc";
            this.mskdDoktorKayitTc.Size = new System.Drawing.Size(211, 34);
            this.mskdDoktorKayitTc.TabIndex = 32;
            this.mskdDoktorKayitTc.ValidatingType = typeof(int);
            // 
            // txtDoktorKayitSifre
            // 
            this.txtDoktorKayitSifre.Location = new System.Drawing.Point(202, 217);
            this.txtDoktorKayitSifre.Margin = new System.Windows.Forms.Padding(7);
            this.txtDoktorKayitSifre.Name = "txtDoktorKayitSifre";
            this.txtDoktorKayitSifre.Size = new System.Drawing.Size(211, 34);
            this.txtDoktorKayitSifre.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "ŞİFRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "TC KİMLİK NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "BRANŞ:";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(202, 270);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(211, 37);
            this.cmbBrans.TabIndex = 38;
//            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // btnDoktorGuncelle
            // 
            this.btnDoktorGuncelle.Location = new System.Drawing.Point(222, 324);
            this.btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            this.btnDoktorGuncelle.Size = new System.Drawing.Size(164, 48);
            this.btnDoktorGuncelle.TabIndex = 39;
            this.btnDoktorGuncelle.Text = "GÜNCELLE";
            this.btnDoktorGuncelle.UseVisualStyleBackColor = true;
            this.btnDoktorGuncelle.Click += new System.EventHandler(this.btnDoktorGuncelle_Click);
            // 
            // FrmDoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 418);
            this.Controls.Add(this.btnDoktorGuncelle);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDoktorKayitSoyad);
            this.Controls.Add(this.txtDoktorKyitAd);
            this.Controls.Add(this.mskdDoktorKayitTc);
            this.Controls.Add(this.txtDoktorKayitSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDoktorBilgiDuzenle";
            this.Text = "FrmDoktorBilgiDuzenle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDoktorKayitSoyad;
        private System.Windows.Forms.TextBox txtDoktorKyitAd;
        private System.Windows.Forms.MaskedTextBox mskdDoktorKayitTc;
        private System.Windows.Forms.TextBox txtDoktorKayitSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button btnDoktorGuncelle;
    }
}