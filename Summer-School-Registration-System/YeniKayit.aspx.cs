using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer; //Başvurular kısmından burayı eklememiz gerekiyor.
using EntityLayer; //Başvurular kısmından burayı eklememiz gerekiyor.
using Business_Logic_Layer; //Başvurular kısmından burayı eklememiz gerekiyor.

namespace Summer_School_Registration_System
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = txtAd.Text;
            ent.Soyad = txtSoyad.Text;
            ent.Numara = txtNumara.Text;
            ent.Sifre = txtSifre.Text;
            ent.Fotograf = txtFotograf.Text;

            BllOgrenci.ogrenciEkleBLL(ent); //Yukarıdan gelen değerleri ekle.
        }
    }
}