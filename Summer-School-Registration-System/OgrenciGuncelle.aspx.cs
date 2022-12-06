using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using Business_Logic_Layer;

namespace Summer_School_Registration_System
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Id'yi textboxa yazdırıp, id değiştirlmeden güncelleme yapılmasını sağlayan yapı.
            int x = Convert.ToInt32(Request.QueryString["id"].ToString());
            txtID.Text = x.ToString();
            txtID.Enabled = false;

            //TextBoxların içerisine hazır gelmesi için bu yapıyı kullanıyoruz.
            List<EntityOgrenci> OgrList = BllOgrenci.ogrenciDetayBLL(x);
            txtAd.Text = OgrList[0].Ad.ToString();
            txtSoyad.Text = OgrList[0].Soyad.ToString();
            txtNumara.Text = OgrList[0].Numara.ToString();
            txtFotograf.Text = OgrList[0].Fotograf.ToString();
            txtSifre.Text = OgrList[0].Sifre.ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = txtAd.Text;
            ent.Soyad = txtSoyad.Text;
            ent.Sifre = txtSifre.Text;
            ent.Numara = txtNumara.Text;
            ent.Fotograf = txtFotograf.Text;
            ent.Id = txtID.Text;

        }
    }
}