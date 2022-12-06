using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Summer_School_Registration_System
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["id"].ToString());
            txtID.Text = x.ToString();
            txtID.Enabled = false;
        }
    }
}