using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using Data_Access_Layer;
using Business_Logic_Layer;

namespace Summer_School_Registration_System
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false) //Veriyi sayfa açık kaldıkça saklı tutar.
            {
                DropDownList1.DataSource = BllDers.BllListele(); //Kaynağı ekteki fonksiyon olsun.
                DropDownList1.DataTextField = "dersAd"; //DropDown içinde ne gözükecek?
                DropDownList1.DataValueField = "id";
                DropDownList1.DataBind(); //İşlemi uygula.

                DropDownList2.DataSource = BllOgrenci.ogrenciListeleBLL();
                DropDownList2.DataTextField = "id";
                DropDownList2.DataValueField = "id";
                DropDownList2.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = DropDownList1.SelectedValue.ToString();
            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.BasvuruOgrenciId = int.Parse(DropDownList2.SelectedValue.ToString());
            ent.BasvuruDersId = int.Parse(DropDownList1.SelectedValue.ToString());
            BllDers.BllTalepEkle(ent); //Ent nesnesinin bütün değerlerini gönder.   
            
        }
    }
}