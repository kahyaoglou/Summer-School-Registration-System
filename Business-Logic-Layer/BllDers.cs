using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using DataAccessLayer;
using EntityLayer;

namespace Business_Logic_Layer
{
    public class BllDers
    {
        public static List<EntityDers> BllListele()
        {
            return DalDers.DersListesi();
        }

        public static int BllTalepEkle(EntityBasvuruForm p)
        {
            if(p.BasvuruOgrenciId != null && p.BasvuruDersId != null)
            {
                return DalDers.talepEkle(p);
            }
            return -1;
        }
    }
}
