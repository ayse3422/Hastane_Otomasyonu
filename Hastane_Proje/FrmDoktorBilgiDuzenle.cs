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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Table_Doktor set DoktorAd=@d1,DoktorSoyad=@d2,DoktorSifre=@d3,DoktorBrans=@d4 where DoktorTc=@d5", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtDoktorKyitAd.Text);
            komut.Parameters.AddWithValue("@d2", txtDoktorKayitSoyad.Text);
            komut.Parameters.AddWithValue("@d3", txtDoktorKayitSifre.Text);
            komut.Parameters.AddWithValue("@d4", cmbBrans.Text);
            komut.Parameters.AddWithValue("@d5", mskdDoktorKayitTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("güncelleme yapılmıstır");
        }
        public string tc;
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskdDoktorKayitTc.Text = tc;

            SqlCommand komutt = new SqlCommand("select * from Table_Doktor where DoktorTc=@d1", bgl.baglanti());
            komutt.Parameters.AddWithValue("@d1", mskdDoktorKayitTc.Text);
            SqlDataReader dr = komutt.ExecuteReader();
            while (dr.Read())
            {
                txtDoktorKyitAd.Text = dr[1].ToString();
                txtDoktorKayitSoyad.Text = dr[2].ToString();
                txtDoktorKayitSifre.Text = dr[5].ToString();
                cmbBrans.Text = dr[3].ToString();
                bgl.baglanti().Close();
            }







        }

       
    }
}
