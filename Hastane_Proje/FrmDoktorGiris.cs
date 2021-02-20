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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        
        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Table_Doktor where DoktorTc=@d1 and DoktorSifre=@d2", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", mskdDoktorTc.Text);
            komut.Parameters.AddWithValue("@d2", txtDoktorSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                FrmDoktorDetay frm = new FrmDoktorDetay();
                frm.tc = mskdDoktorTc.Text;
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("hatalı tc ya da şifre");
            }
            bgl.baglanti().Close();

            

           
            

        }
        
        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {
            
        }
    }
}
