using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer; //Başvurular kısmından burayı eklememiz gerekiyor.

namespace DataAccessLayer
{
    public class DalOgrenci
    {
        //Öğrenci ekelyen fonksiyonumuzu oluşturalım.
        public static int ogrenciEkle(EntityOgrenci ekle) //Entity kütüphanesinden ekle adından nesne oluştur.
        {
            SqlCommand komut1 = new SqlCommand("insert into tbl_Ogrenci(ogrAd, ogrSoyad, ogrNumara,ogrFoto,ogrSifre) values(@p1,@p2,@p3,@p4,@p5)", Baglanti.baglanti);
            //Baglanti data access layer'ı üzerinden baglanti nesnesini kullanarak veritabanına erişimi sağladık.

            if (komut1.Connection.State != ConnectionState.Open) //Connection state üzerinden bağlantı kurulmamışsa;
            {
                komut1.Connection.Open(); //Bağlantımı aç.
            }

            komut1.Parameters.AddWithValue("@p1", ekle.Ad); //Entity'deki değişkenlere bu değerleri ata.
            komut1.Parameters.AddWithValue("@p2", ekle.Soyad);
            komut1.Parameters.AddWithValue("@p3", ekle.Numara);
            komut1.Parameters.AddWithValue("@p4", ekle.Fotograf);
            komut1.Parameters.AddWithValue("@p5", ekle.Sifre);

            return komut1.ExecuteNonQuery(); //Etkilenen kayıt sayısını geri döndürüyoruz.
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            //Entity öğrenci clasının içerisindeki değerler neyse, listin o değerleri almasını istiyoruz.
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            //Entity öğrenci classındaki verileri kullanan listten, degerler adında bir nesne oluşturuyoruz.
            SqlCommand komut2 = new SqlCommand("SELECT * FROM tbl_Ogrenci", Baglanti.baglanti);
            //Baglanti data access layer'ı üzerinden baglanti nesnesini kullanarak veritabanına erişimi sağladık.
            if (komut2.Connection.State != ConnectionState.Open) //Connection state üzerinden bağlantı kurulmamışsa;
            {
                komut2.Connection.Open(); //Bağlantımı aç.
            }
            SqlDataReader dr = komut2.ExecuteReader(); //Bağlantımı oku ve dr nesnesine ata
            while (dr.Read()) //dr nesnesinin içeriğini okudukça...
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(dr["ogrID"].ToString());
                ent.Ad = dr["ogrAd"].ToString();
                ent.Soyad = dr["ogrSoyad"].ToString();
                ent.Numara = dr["ogrNumara"].ToString();
                ent.Fotograf = dr["ogrFoto"].ToString();
                ent.Sifre = dr["ogrSifre"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["ogrBakiye"].ToString());

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool ogrenciSil(int sil)
        {
            SqlCommand komut3 = new SqlCommand("delete FROM tbl_Ogrenci WHERE ogrID=@P1", Baglanti.baglanti);
            if (komut3.Connection.State != ConnectionState.Open) //Connection state üzerinden bağlantı kurulmamışsa;
            {
                komut3.Connection.Open(); //Bağlantımı aç.
            }
            komut3.Parameters.AddWithValue("@p1", sil); //Presentationdan gelen değer (sil) p1'e atanır.
            //komut3'ten gelen komuttaki p1 artık (sil) olur.
            return komut3.ExecuteNonQuery() > 0; //Değer silme işlemi yapılır. Geri döndürülür.
        }

        public static List<EntityOgrenci> ogrenciDetayDAL(int id)
        {
            //Entity öğrenci clasının içerisindeki değerler neyse, listin o değerleri almasını istiyoruz.
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            //Entity öğrenci classındaki verileri kullanan listten, degerler adında bir nesne oluşturuyoruz.
            SqlCommand komut4 = new SqlCommand("SELECT * FROM tbl_Ogrenci where ogrID = @p1", Baglanti.baglanti);
            //Baglanti data access layer'ı üzerinden baglanti nesnesini kullanarak veritabanına erişimi sağladık.
            komut4.Parameters.AddWithValue("@p1", id);
            if (komut4.Connection.State != ConnectionState.Open) //Connection state üzerinden bağlantı kurulmamışsa;
            {
                komut4.Connection.Open(); //Bağlantımı aç.
            }
            SqlDataReader dr = komut4.ExecuteReader(); //Bağlantımı oku ve dr nesnesine ata
            while (dr.Read()) //dr nesnesinin içeriğini okudukça...
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ad = dr["ogrAd"].ToString();
                ent.Soyad = dr["ogrSoyad"].ToString();
                ent.Numara = dr["ogrNumara"].ToString();
                ent.Fotograf = dr["ogrFoto"].ToString();
                ent.Sifre = dr["ogrSifre"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["ogrBakiye"].ToString());

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool ogrenciGuncelleDAL(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("UPDATE tbl_Ogrenci SET ogrAd=@p1, ogrSoyad=@p2, ogrNumara=@p3, ogrFoto=@p4, ogrSifre=@p5 WHERE ogrID=@p6", Baglanti.baglanti);

            if (komut5.Connection.State != ConnectionState.Open) //Connection state üzerinden bağlantı kurulmamışsa;
            {
                komut5.Connection.Open(); //Bağlantımı aç.
            }

            komut5.Parameters.AddWithValue("@p1", deger.Ad);
            komut5.Parameters.AddWithValue("@p2", deger.Soyad);
            komut5.Parameters.AddWithValue("@p3", deger.Numara);
            komut5.Parameters.AddWithValue("@p4", deger.Fotograf);
            komut5.Parameters.AddWithValue("@p5", deger.Sifre);
            komut5.Parameters.AddWithValue("@p6", deger.Id);

            return komut5.ExecuteNonQuery() > 0; //komut5'in sıfırdan büyük değerini döndür.
        }

    }
}
