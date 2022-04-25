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
    public partial class frmdoktorpaneli : Form
    {
        public frmdoktorpaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmdoktorpaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from tbl_doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // bransları combxa aktarma 
            SqlCommand komut2 = new SqlCommand("select bransad from tbl_branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_doktorlar (doktorad,doktorsoyad,doktorbrans,doktortc,doktorsifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtad.Text);
            komut.Parameters.AddWithValue("@d2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@d4", msktc.Text);
            komut.Parameters.AddWithValue("@d5", txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);//paremetreli 


        }

     

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //amac burda herhangi bir hücreye tıklandığında o satırın verilerini güsterecek 
            int secilen = dataGridView1.SelectedCells[0].RowIndex;//hücrenin sıfırıncı sutununa göre satır indexini alsın 
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msktc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" delete from tbl_doktorlar where doktortc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_doktorlar set doktorad=@d1,doktorsoyad=@d2,doktorbrans=@d3,doktorsifre=@d5 where doktortc=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtad.Text);
            komut.Parameters.AddWithValue("@d2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@d4", msktc.Text);
            komut.Parameters.AddWithValue("@d5", txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);//paremetreli 
        }
    }
}
