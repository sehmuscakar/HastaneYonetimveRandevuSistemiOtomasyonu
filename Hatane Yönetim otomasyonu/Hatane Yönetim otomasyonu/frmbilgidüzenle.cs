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
    public partial class frmbilgidüzenle : Form
    {
        public frmbilgidüzenle()
        {
            InitializeComponent();
        }
        public string TCno;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmbilgidüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = TCno;
            SqlCommand komut = new SqlCommand("select * from tbl_hastalar where hastatc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();//0 ncı index değil çünkü 0 da id var 
                txtsoyad.Text = dr[2].ToString();
                msktelefon.Text = dr[4].ToString();
                txtsifre.Text = dr[5].ToString();
                combxcinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnbilgigüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update tbl_hastalar set hastaad=@p1,hastasoyad=@p2,hastatelefon=@p3,hastasifre=@p4,hastacinsiyet=@p5 where hastatc=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtad.Text);
            komut2.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", msktelefon.Text);
            komut2.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut2.Parameters.AddWithValue("@p5", combxcinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", msktc.Text);
            komut2.ExecuteNonQuery();// bu işlemleri kaydetmek için bu komutu kulanırız 
            // bu komut insert update delete sorgularında çalışır , bu sorguları çalıştırmak için kulanılan komutumuz 
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //MessageBoxButtons.OK bu evet hayır cıkması saplar mesajkutusunda 
            //MessageBoxIcon.Warning bu da ıconda uyarı verir warning 
        }
    }
}
