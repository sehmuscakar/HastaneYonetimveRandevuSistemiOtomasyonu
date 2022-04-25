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
    public partial class frmsekreterdetay : Form
    {
        public frmsekreterdetay()
        {
            InitializeComponent();
        }


        public string tcnumara;// bunu açık yapmasak sekretergiriş  kısmında karşımıza gelmez 
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmsekreterdetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tcnumara;//sağdan sola aktarma 
                                  //kısacası msktc yi tcnumara ya aktardık tcnumara yıda lbltc ye aktardık nesne yardımıyla
                                  // bişeyi 1 den 3 ü yere gütürdük gibi düşün 

            //Ad Soyad
            SqlCommand komut1 = new SqlCommand("select sekreteradsoyad from tbl_sekreterler where sekretertc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //branşları datagrivde aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView2.DataSource = dt1;

            // doktorları listeye aktarma 
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tbl_doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView3.DataSource = dt2;


            //branşı comboboxa aktarma 
            SqlCommand komut2 = new SqlCommand("select bransad from tbl_branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();

        }

        
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into tbl_randevular (randevutarih,randevusaat,randevubrans,randevudoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", mskssaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            komutkaydet.ExecuteNonQuery();//değişiklikleri kaydetmek için 
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();// temizleme 

            SqlCommand komut = new SqlCommand("select doktorad,doktorsoyad from tbl_doktorlar where doktorbrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                cmbdoktor.Items.Add(dr[0] + " " + dr[1]);// brans ta brans secildiğinde doktor ve soyisism adları gelecek 
            }
            bgl.baglanti().Close();
        }

        private void btnduyuruolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rchduyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("DUYURU OLUŞTURULDU");

        }

        private void btndoktorpaneli_Click(object sender, EventArgs e)
        {
            frmdoktorpaneli drp = new frmdoktorpaneli();
            drp.Show();

        }

        private void btnbranspaneli_Click(object sender, EventArgs e)
        {
            frmbranspaneli frb = new frmbranspaneli();
            frb.Show();
        }

        private void btnrandevuliste_Click(object sender, EventArgs e)
        {
            frmrandevulistesi frl = new frmrandevulistesi();
            frl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmduyurular fr = new frmduyurular();
            fr.Show();
        }
    }
}
