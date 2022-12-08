using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public static class Baglanti
        /* Data Access Layer katmanının Baglanti sınıfında, sql kütüphanesi ve baglanti nesnesi
         üzerinden veritabanı bağlantısı yapmaktayız.*/
        /* Bu nesneyi öteki classlarda çağıracağız. O nedenle public tanımlamalıyız.*/
    {
        public static SqlConnection baglanti = new SqlConnection(
            @"Data Source=DESKTOP-3DO8R5T;Initial Catalog=yazOkulu;Integrated Security=true;");
    }
}
