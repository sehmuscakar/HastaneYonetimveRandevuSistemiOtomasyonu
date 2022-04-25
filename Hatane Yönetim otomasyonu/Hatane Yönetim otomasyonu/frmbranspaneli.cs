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
    public partial class frmbranspaneli : Form
    {
        public frmbranspaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmbranspaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_branslar (bransad) values (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtbransad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtbransid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtbransad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {                                          // küçük büyük harf zorunluluğu yok 
            SqlCommand komut = new SqlCommand("delete from tbl_branslar where bransid=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtbransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {//eğer hatta alırsan hatta mesajında üste daha cok odaklan 
            SqlCommand komut = new SqlCommand("update tbl_branslar set bransad=@p1 where bransid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtbransad.Text);
            komut.Parameters.AddWithValue("@p2", txtbransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi");

        }
    }
}
