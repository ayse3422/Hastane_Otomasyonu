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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        public string tc;
       
        private void lblHastaTc_Click(object sender, EventArgs e)
        {
            lblHastaTc.Text = tc;
            SqlCommand komut = new SqlCommand("select HastaAd,HastaSoyad from Table_Hasta where HastaTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblHastaTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblHastaAdSoyad.Text=dr[0] +" "+ dr[1];
            }
            bgl.baglanti().Close();
             
            //randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select * from Table_Randevular where HastaTc=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //brans cekme
            SqlCommand komut2 = new SqlCommand("select BransAd from Table_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
                
            }
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from Table_Doktor where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] +" " + dr3[1]);
            }
            bgl.baglanti().Close();
                
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select * from  Table_Randevular where RandevuBrans='" + cmbBrans.Text + "'" +" and RandevuDoktor ='"+cmbDoktor.Text+"' and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void lnkBilgileriniDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiGuncelle frm = new FrmBilgiGuncelle();
            frm.tcno = lblHastaTc.Text;
            
            
            
           
            
            frm.Show();
            
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("update Table_Randevular set RandevuDurum=1,HastaTc=@p1,HastaSikayet=@p2 where Randevuid=@p3",bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", lblHastaTc.Text);
            komut4.Parameters.AddWithValue("@p2", richSikayet.Text);
            komut4.Parameters.AddWithValue("@p3", txtİd.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("randevunuz oluşturulmuştur.");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtİd.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
