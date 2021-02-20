using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Proje
{
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void btnHastaKayitYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Hasta (HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
           
            komut.Parameters.AddWithValue("@p1", txtHastaKyitAd.Text);
            komut.Parameters.AddWithValue("@p2", txtHastaKayitSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskdHastaKayitTc.Text);
            komut.Parameters.AddWithValue("@p4", mskdHastaKayitTelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtHastaKayitSifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbHastaKayitCinsiyet.Text);
            komut.ExecuteNonQuery(); 
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız tamamlanmıştır.Şifreniz:" + txtHastaKayitSifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            
        }
        
        private void mskdHastaKayitTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }
    }
}
