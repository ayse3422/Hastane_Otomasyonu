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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btnSekreterGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" select * from Table_Sekreter where SekreterTc=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskdSekreterTc.Text);
            komut.Parameters.AddWithValue("@p2", txtSekreterSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetayPaneli frm = new FrmSekreterDetayPaneli();
                frm.tc = mskdSekreterTc.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı tc ya da sifre");
            }


        }
       
        private void mskdSekreterTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {
           
        }
    }
}
