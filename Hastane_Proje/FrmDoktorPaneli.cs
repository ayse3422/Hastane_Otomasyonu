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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Table_Doktor", bgl.baglanti());
            da2.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglanti().Close();

            SqlCommand kom = new SqlCommand("select BransAd from Table_Brans ", bgl.baglanti());
            SqlDataReader drr = kom.ExecuteReader();
            while (drr.Read())
            {
                cmbBrans.Items.Add(drr[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           
            SqlCommand komut1 = new SqlCommand("insert into Table_Doktor (DoktorAd,DoktorSoyad,DoktorBrans,DoktorSifre,DoktorTc) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@d1", txtAd.Text);
            komut1.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut1.Parameters.AddWithValue("@d3", cmbBrans.Text);
            komut1.Parameters.AddWithValue("@d4", txtSifre.Text);
            komut1.Parameters.AddWithValue("@d5", mskdTc.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("doktor eklenmiştir");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("delete from Table_Doktor where DoktorAd = @p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", txtAd.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("doktor silinmiştir");
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komuttt = new SqlCommand("update Table_Doktor set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d4 where DoktorTc=@d5",bgl.baglanti());
            komuttt.Parameters.AddWithValue("@d1", txtAd.Text);
            komuttt.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komuttt.Parameters.AddWithValue("@d3", cmbBrans.Text);
            komuttt.Parameters.AddWithValue("@d4", txtSifre.Text);
            komuttt.Parameters.AddWithValue("@d5", mskdTc.Text);
            komuttt.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
           cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskdTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            
        }

       
    }
}
