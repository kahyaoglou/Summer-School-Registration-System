using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityOgretmen
    {
        private int ogretmenId;
        private string ogretmanAd;
        private int ogretmenBrans;

        public int OgretmenId { get => ogretmenId; set => ogretmenId = value; }
        public string OgretmanAd { get => ogretmanAd; set => ogretmanAd = value; }
        public int OgretmenBrans { get => ogretmenBrans; set => ogretmenBrans = value; }
    }
}
