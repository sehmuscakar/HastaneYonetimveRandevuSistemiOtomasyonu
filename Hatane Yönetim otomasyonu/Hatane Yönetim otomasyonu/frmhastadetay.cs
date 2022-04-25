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
    public partial class frmhastadetay : Form
    {
        public frmhastadetay()
        {
            InitializeComponent();
        }

        public string tc;// bunu global bir şekilde yaptık 
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void frmhastadetay_Load(object sender, EventArgs e)
        {
            lbltc.Text=tc;
            // ad soyad cekme işlemi veya komutları 
            SqlCommand komut = new SqlCommand("select hastaad,hastasoyad from tbl_hastalar where hastatc=@p1", bgl.baglanti());// burda where koşulu ile hsstatc sine göre hastaad hastasoyad gtirir
            komut.Parameters.AddWithValue("@p1", lbltc.Text);//"@p1", lbltc.Text bu ikisini ilişkilendirdik 
            SqlDataReader dr = komut.ExecuteReader();//komut okuma işlemi gibi düşün dr okuma yapacak 
            while(dr.Read())
            {
                lbladsoyad.Text = dr[0] +" " +dr[1]; // eğer arada string ifade varsa string değere cevirmeye gerek yok 
              //select hastaad,hastasoyad  bu kısım 0 index i secer ve devam eder 
           
            }
            bgl.baglanti().Close();
            //randevu geçmişi (datgridv)
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where hastatc=" + tc, bgl.baglanti()); // bu datagrivde verileri command yapmak için kulanlır 
            //sqldataadapter da paremetre kulanılmıyor satır içinde kulanılıyor 
            //hastatc = " + tc, bu kısımda hastatc eşit olan tc ye göre getirecek paretme tc yerine lbltc de yazabilirsin fark etmez 

            //datagrievde baglanti acıp kapatmaya gerek 
            da.Fill(dt); // da ile dataadepter içini doldur neyle dt den gelecek tablo değeri ile (sanal tablo oluşturma mantığı )
            //dataGridView1.DataSource = dt;// dataGridView1 veri kaynağı dt den gelen tablo 
            //verileri çekme 
            SqlCommand komut2 = new SqlCommand("select bransad from tbl_branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select doktorad,doktorsoyad from tbl_doktorlar where doktorbrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0] + "  " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // c# taki tek tırnak anlamı sql deki tek tırnak kulanımı sql de kelime başı arama yapıldığı zaman tek tırnak içine yazılır unutma 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where randevubrans='" + cmbbrans.Text + "'"  ,bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkbilgidüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmbilgidüzenle fr = new frmbilgidüzenle();
            fr.TCno = lbltc.Text;//TCno yu fr nesnes yardımıyla lbltc ye taşı 
                fr.Show();
        }

        private void btnrandevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_randevular set randevudurum=1,hastatc=@p1,hastasikayet=@p2 where randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            komut.Parameters.AddWithValue("@p2", rchtxtsikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
