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
    public partial class frmsekretergiris : Form
    {
        public frmsekretergiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btngiriş_Click(object sender, EventArgs e)
        {
            //while olmayacak if olacak çünkü okuma işlemi doğrumu değilmi onu kontrol ediyoruz sorgulama yapıyoruz 
            SqlCommand komut = new SqlCommand("select * from tbl_sekreterler where sekretertc=@p1 and sekretersifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmsekreterdetay frs = new frmsekreterdetay();
                frs.tcnumara = msktc.Text;// sağdan sola atama aklına gelsin 
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre");

            }
            bgl.baglanti().Close();
        }

      
    }
}
