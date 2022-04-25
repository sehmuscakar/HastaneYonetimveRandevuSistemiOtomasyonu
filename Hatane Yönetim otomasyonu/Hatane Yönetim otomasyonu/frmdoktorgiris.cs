using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatane_Yönetim_otomasyonu
{
    public partial class frmdoktorgiris : Form
    {
        public frmdoktorgiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btngiriş_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_doktorlar where doktortc=@p1 and doktorsifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmdoktordetay fr = new frmdoktordetay();
                fr.tc = msktc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatallı Kullanıcı adı veya şifre");
            }
            bgl.baglanti().Close();
        }

        private void lnkuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmdoktorpaneli fr = new frmdoktorpaneli();
             fr.Show();
        }
    }
}
