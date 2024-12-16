using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class OgrenciGüncelle : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["OGRID"]);
            TxtOgrID.Text = id.ToString();
            DataSet1TableAdapters.TBLOGRTableAdapter dt = new DataSet1TableAdapters.TBLOGRTableAdapter();
            TxtOgrNumara.Text = dt.OgrenciSec(id)[0].OGRNUMARA;
            TxtOgrAd.Text = dt.OgrenciSec(id)[0].OGRAD;
            TxtOgrSoyad.Text = dt.OgrenciSec(id)[0].OGRSOYAD;
            TxtOgrFotograf.Text = dt.OgrenciSec(id)[0].OGRFOTOGRAF;
            TxtOgrTelefon.Text = dt.OgrenciSec(id)[0].OGRTELEFON;
            TxtOgrMaıl.Text = dt.OgrenciSec(id)[0].OGRMAIL;
            TxtOgrSıfre.Text = dt.OgrenciSec(id)[0].OGRSIFRE;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLOGRTableAdapter dt = new DataSet1TableAdapters.TBLOGRTableAdapter();
            dt.OgrenciGüncelle(TxtOgrNumara.Text,TxtOgrAd.Text, TxtOgrSoyad.Text, TxtOgrFotograf.Text, TxtOgrTelefon.Text, TxtOgrMaıl.Text,
                TxtOgrSıfre.Text, Convert.ToInt32(TxtOgrID.Text));
            Response.Redirect("Default.aspx");
        }
    }
}