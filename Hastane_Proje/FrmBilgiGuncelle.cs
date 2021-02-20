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
    public partial class FrmBilgiGuncelle : Form
    {
        public FrmBilgiGuncelle()
        {
            InitializeComponent();
        }
        public string tcno;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmBilgiGuncelle_Load(object sender, EventArgs e)
        {
            mskdHastaKayitTc.Text = tcno;
            SqlCommand komut = new SqlCommand("select * from Table_Hasta where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskdHastaKayitTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtHastaKyitAd.Text = dr[1].ToString();
                txtHastaKayitSoyad.Text = dr[2].ToString();
                mskdHastaKayitTelefon.Text = dr[4].ToString();
                txtHastaKayitSifre.Text = dr[5].ToString();
                cmbHastaKayitCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
           

           
        }

        

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Table_Hasta set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtHastaKyitAd.Text);
            komut2.Parameters.AddWithValue("@p2", txtHastaKayitSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", mskdHastaKayitTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", txtHastaKayitSifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbHastaKayitCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", mskdHastaKayitTc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("kaydınız güncellenmiiştir", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        
    }
}
