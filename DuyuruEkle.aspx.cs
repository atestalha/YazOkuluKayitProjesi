using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DuyuruEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLOGRETMENTableAdapter dt = new DataSet1TableAdapters.TBLOGRETMENTableAdapter();
            DropDownList1.DataSource = dt.OgretmenListesi();
            DropDownList1.DataTextField = "OGRTAD";
            DropDownList1.DataValueField = "OGRTID";
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLDUYURUTableAdapter dt = new DataSet1TableAdapters.TBLDUYURUTableAdapter();
            dt.DuyuruEkle(TxtDuyuruBaslık.Text, TextArea1.Value.ToString(), Convert.ToInt32(DropDownList1.SelectedValue));
            Response.Redirect("DuyuruListesi.aspx");
        }
    }
}