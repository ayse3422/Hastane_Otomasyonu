namespace Hastane_Proje
{
    partial class FrmSekreterGiris
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
            this.btnSekreterGiris = new System.Windows.Forms.Button();
            this.mskdSekreterTc = new System.Windows.Forms.MaskedTextBox();
            this.txtSekreterSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSekreterGiris
            // 
            this.btnSekreterGiris.Location = new System.Drawing.Point(212, 187);
            this.btnSekreterGiris.Name = "btnSekreterGiris";
            this.btnSekreterGiris.Size = new System.Drawing.Size(156, 36);
            this.btnSekreterGiris.TabIndex = 13;
            this.btnSekreterGiris.Text = "GİRİŞ YAP";
            this.btnSekreterGiris.UseVisualStyleBackColor = true;
            this.btnSekreterGiris.Click += new System.EventHandler(this.btnSekreterGiris_Click);
            // 
            // mskdSekreterTc
            // 
            this.mskdSekreterTc.Location = new System.Drawing.Point(185, 101);
            this.mskdSekreterTc.Mask = "00000000000";
            this.mskdSekreterTc.Name = "mskdSekreterTc";
            this.mskdSekreterTc.Size = new System.Drawing.Size(183, 36);
            this.mskdSekreterTc.TabIndex = 1;
            this.mskdSekreterTc.ValidatingType = typeof(int);
            this.mskdSekreterTc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskdSekreterTc_MaskInputRejected);
            // 
            // txtSekreterSifre
            // 
            this.txtSekreterSifre.Location = new System.Drawing.Point(185, 145);
            this.txtSekreterSifre.Name = "txtSekreterSifre";
            this.txtSekreterSifre.Size = new System.Drawing.Size(183, 36);
            this.txtSekreterSifre.TabIndex = 2;
            this.txtSekreterSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "ŞİFRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "TC KİMLİK NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "SEKRETER GİRİŞ PANELİ";
            // 
            // FrmSekreterGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(528, 278);
            this.Controls.Add(this.btnSekreterGiris);
            this.Controls.Add(this.mskdSekreterTc);
            this.Controls.Add(this.txtSekreterSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSekreterGiris";
            this.Text = "FrmSekreterGiris";
            this.Load += new System.EventHandler(this.FrmSekreterGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSekreterGiris;
        private System.Windows.Forms.MaskedTextBox mskdSekreterTc;
        private System.Windows.Forms.TextBox txtSekreterSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}