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
    public partial class FrmSekreterDetayPaneli : Form
    {
        public FrmSekreterDetayPaneli()
        {
            InitializeComponent();
        }

       
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string tc;
      

        private void FrmSekreterDetayPaneli_Load(object sender, EventArgs e)
        {
            lblSekreterTc.Text = tc;
           

            //ad soyad cekme
            SqlCommand komut1 = new SqlCommand("select SekreterAdSoyad from Table_Sekreter where SekreterTc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",lblSekreterTc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblSekreterAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();



            //bransları cekme

            DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select BransAd from Table_Brans", bgl.baglanti());
            da1.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();

            //doktorları cekme

            DataTable dt1 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select DoktorAd , DoktorSoyad , DoktorBrans from Table_Doktor", bgl.baglanti());
            da2.Fill(dt1);
            dataGridView2.DataSource = dt1;
            bgl.baglanti().Close();

            //bransları comboboxa cekme

            SqlCommand kom = new SqlCommand("select BransAd from Table_Brans ", bgl.baglanti());
            SqlDataReader drr = kom.ExecuteReader();
            while (drr.Read())
            {
                cmbBrans.Items.Add(drr[0]);
            }
            bgl.baglanti().Close();
            
        }

        private void btnRandevuolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Table_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", mskdTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", mskdSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu olusturuldu");
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from Table_Doktor where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Duyurular (Duyuru) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", richDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("duyuru oluşturuldu");
        }

        private void btnRandevuDuzenle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frm = new FrmDoktorPaneli();
            frm.Show();
            this.Hide();
        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBransPaneli frm = new FrmBransPaneli();
            frm.Show();
          
        }

        private void btnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frm = new FrmRandevuListesi();
            frm.Show();
            
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete Table_Randevular where HastaTc=@r1", bgl.baglanti());
            komut.Parameters.AddWithValue("@r1", mskdTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("randevu silindi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }
    }
}
