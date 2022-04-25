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
    public partial class frmdoktordetay : Form
    {
        public frmdoktordetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tc;
        private void frmdoktordetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;

            //doktor ad soyad
            SqlCommand komut = new SqlCommand("select doktorad,doktorsoyad from tbl_doktorlar where doktortc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();


            //Randevular

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where randevudoktor='" + lbladsoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnbilgidüzenle_Click(object sender, EventArgs e)
        {
            frmdoktorbilgidüzenle fr = new frmdoktorbilgidüzenle();
            fr.tcno = lbltc.Text;
            fr.Show();
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            frmduyurular fr = new frmduyurular();
            fr.Show();
        }

        private void btncıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();//programdan çık yani 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
