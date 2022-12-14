using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer; //Başvurular kısmından burayı eklememiz gerekiyor.
using DataAccessLayer; //Başvurular kısmından burayı eklememiz gerekiyor.

namespace Business_Logic_Layer
{
    public class BllOgrenci
    {
        public static int ogrenciEkleBLL(EntityOgrenci p)
            //Önce entity'i p nesnesi ile okuyacak. Hafızaya değişkenleri atayacak.
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null & p.Sifre != null && p.Fotograf != null)
            //Sonra bu değişkenlere p nesnesi yardımıyla değer atanmış mı atanmamış mı onu kontrol edecek.
            {
                return DalOgrenci.ogrenciEkle(p);
                //Değer atanmışsa DAL'daki ogrenciEkle fonksiyonunu p nesnesini parametre göndererek döndürecek.
            }
            else
                return -1; //Ters döndür, işlemi yapma.
        }

        public static List<EntityOgrenci> ogrenciListeleBLL()
        {
            return DalOgrenci.OgrenciListesi();
            //Data Access Layer'daki OğrenciListesini geri döndüren bir liste fonksiyonu tanımladık.
        }

        public static bool ogrenciSilBLL(int p)
        {
            if (p >= 0)
            {
                return DalOgrenci.ogrenciSil(p);
            }
            return false;
        }

        public static List<EntityOgrenci> ogrenciDetayBLL(int p)
        {
            return DalOgrenci.ogrenciDetayDAL(p);
            //Data Access Layer'daki OğrenciListesini geri döndüren bir liste fonksiyonu tanımladık.
        }

        public static bool ogrenciGuncelleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Ad != " " && p.Ad != "" && p.Soyad != null && p.Numara != null & p.Sifre != null && p.Fotograf != null && p.Id > 0)
            {
                return DalOgrenci.ogrenciGuncelleDAL(p);
            }
            return false;
        }
    }
}
