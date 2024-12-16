using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DuyuruGüncelle : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                id = Convert.ToInt32(Request.QueryString["DUYURUID"]);
                DataSet1TableAdapters.TBLDUYURUTableAdapter dt = new DataSet1TableAdapters.TBLDUYURUTableAdapter();
                TxtDuyuruID.Text = id.ToString();
                TxtDuyuruBaslık.Text = dt.DuyuruSec(id)[0].DUYURUBASLIK;
                TextArea1.Value = dt.DuyuruSec(id)[0].DUYURUICERIK;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLDUYURUTableAdapter dt = new DataSet1TableAdapters.TBLDUYURUTableAdapter();
            dt.DuyuruGüncelle(TxtDuyuruBaslık.Text, TextArea1.Value.ToString(), Convert.ToInt32(TxtDuyuruID.Text));
            Response.Redirect("DuyuruListesi.aspx");
        }
    }
}