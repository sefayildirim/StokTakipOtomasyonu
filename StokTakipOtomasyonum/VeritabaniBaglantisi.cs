using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonum
{
    public static class VeritabaniBaglantisi
    {
        public static SqlConnection BaglantiyiAl()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=localhost,1433;Initial Catalog=stok;User ID=sa;Password=yourStrong(!)Password");
            return baglanti;
        }
    }
}
