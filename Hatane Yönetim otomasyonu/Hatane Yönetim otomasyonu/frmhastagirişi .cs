using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hatane_Yönetim_otomasyonu
{
    public partial class frmhastagirişi : Form
    {
        public frmhastagirişi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void lnkuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmhastakayıt fr = new frmhastakayıt();
            fr.Show();

        }

        private void btngiriş_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_hastalar where hastatc=@p1 and hastasifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmhastadetay fr = new frmhastadetay();
                fr.tc = msktc.Text;//msktc den gelen değeri lbltc ye yazdırdık nesne yardımıyla
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("HATALI TC & ŞİFRE ");
            }
            bgl.baglanti().Close();

        }

 
    }
}
