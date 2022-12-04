using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using Business_Logic_Layer;
using DataAccessLayer;

namespace Summer_School_Registration_System
{
    public partial class OgrenciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenci> ogrList = BllOgrenci.ogrenciListeleBLL();
            //EntityOgrenci listesinin tipinden bir nesne türettik.
            //Business logic kayerdaki fonksiyonu bu nesneye atadık.
            Repeater1.DataSource = ogrList; //Bu liste nesnesini repeatera atadık.
            Repeater1.DataBind(); //Bind ile de eklemiş olduk.

        }
    }
}