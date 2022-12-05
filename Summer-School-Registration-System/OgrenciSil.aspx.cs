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
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["id"]);
            //OgrenciListele formundan taşınan değeri x'e ata.
            Response.Write(x); //x', yazdır.

            EntityOgrenci ent = new EntityOgrenci();
            ent.Id = x;
            BllOgrenci.ogrenciSilBLL(ent.Id);
            Response.Redirect("OgrenciListesi.aspx"); //Linke beni yönlendir.
        }
    }
}