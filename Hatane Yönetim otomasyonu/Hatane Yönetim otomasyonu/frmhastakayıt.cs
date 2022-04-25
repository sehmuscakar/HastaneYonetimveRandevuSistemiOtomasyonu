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
    public partial class frmhastakayıt : Form
    {
        public frmhastakayıt()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnkayıtyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_hastalar (hastaad,hastasoyad,hastatc,hastatelefon,hastasifre,hastacinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);// böyle values te eklemek yerine burdaa paremetreler ile ekleyebilirsin 
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", msktelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtsifre.Text);
            komut.Parameters.AddWithValue("@p6", combxcinsiyet.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();// bgl nesnesinden giderek ulaşirsin veritabanına burdan 
            MessageBox.Show("KAYDINIZ GERÇEKLEŞMİŞTİR ŞİFRENİZ:" + txtsifre.Text,"BİLGİ",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

        }
    }
}
