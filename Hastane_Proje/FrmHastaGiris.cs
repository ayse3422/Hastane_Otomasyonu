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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }


        SqlBaglantisi bgl = new SqlBaglantisi();
        private void linklblHastaUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit frm = new FrmHastaKayit();
            frm.Show();
        }
        

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" select * from  Table_Hasta where HastaTc=@p1 and HastaSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskdHastaTc.Text);
            komut.Parameters.AddWithValue("@p2", txtHastaSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay frm = new FrmHastaDetay();
                frm.tc = mskdHastaTc.Text;
                frm.Show();
                this.Hide(); 

            }
            else
            {
                MessageBox.Show("Hatali TC ya da hatalı şifre","Bilgi",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();

           
            

          

            
           
          
        }
    }
}
