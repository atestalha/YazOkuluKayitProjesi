using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class OgrenciEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLOGRTableAdapter dt = new DataSet1TableAdapters.TBLOGRTableAdapter();
            dt.OgrenciEkle(TxtOgrNumara.Text,TxtOgrAd.Text,TxtOgrSoyad.Text, TxtOgrFotograf.Text, TxtOgrTelefon.Text, TxtOgrMaıl.Text, TxtOgrSıfre.Text);
            Response.Redirect("Default.aspx");
        }
    }
}