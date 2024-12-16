using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class MesajYaz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            DataSet1TableAdapters.TBLMESAJTableAdapter dt = new DataSet1TableAdapters.TBLMESAJTableAdapter();
            DateTime tarih;
            if (DateTime.TryParse(TxtTarih.Text, out tarih))
            {
                dt.MesajGonder(TxtGonderen.Text, TxtAlici.Text, TxtIcerık.Value, TxtBaslik.Text, tarih);
                Response.Redirect("GidenMesajlar.aspx");
            }
            else
            {

                Response.Write("");
            }
        }
    }
}