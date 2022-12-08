using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using DataAccessLayer;

namespace Data_Access_Layer
{
    public class DalDers
    {
        public static List<EntityDers> DersListesi()
        {
            //Entity öğrenci clasının içerisindeki değerler neyse, listin o değerleri almasını istiyoruz.
            List<EntityDers> degerler = new List<EntityDers>();
            //Entity öğrenci classındaki verileri kullanan listten, degerler adında bir nesne oluşturuyoruz.
            SqlCommand komut2 = new SqlCommand("SELECT * FROM tbl_Dersler", Baglanti.baglanti);
            //Baglanti data access layer'ı üzerinden baglanti nesnesini kullanarak veritabanına erişimi sağladık.
            if (komut2.Connection.State != ConnectionState.Open) //Connection state üzerinden bağlantı kurulmamışsa;
            {
                komut2.Connection.Open(); //Bağlantımı aç.
            }
            SqlDataReader dr = komut2.ExecuteReader(); //Bağlantımı oku ve dr nesnesine ata
            while (dr.Read()) //dr nesnesinin içeriğini okudukça...
            {
                EntityDers ent = new EntityDers();
                ent.Id = Convert.ToInt32(dr["ogrID"].ToString());
                ent.DersAd = dr["dersAd"].ToString();
                ent.Min = int.Parse( dr["dersMinKontenjant"].ToString() );
                ent.Max = int.Parse( dr["dersMaxKontenjant"].ToString() );

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
