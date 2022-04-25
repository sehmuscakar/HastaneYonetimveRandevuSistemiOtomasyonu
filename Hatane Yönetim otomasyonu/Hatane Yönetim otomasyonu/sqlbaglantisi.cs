using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient; // bu kütüphane sqlconnection command ve bir cok şeye yarıyor 
using System.Threading.Tasks;

namespace Hatane_Yönetim_otomasyonu
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()//metot dumun ismi 
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-O9RRR03;Initial Catalog=HataneProje;Integrated Security=True");// \\ koyman adres olduğu belirtir yada @ bunu hangisini kulanırsan 
            baglan.Open();
            return baglan;//geriye bunu gönder baglan adresini yani bu yüntemi unutma 
        }

    }
}
