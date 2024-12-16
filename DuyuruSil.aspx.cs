using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DuyuruSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["DUYURUID"]);
            DataSet1TableAdapters.TBLDUYURUTableAdapter dt = new DataSet1TableAdapters.TBLDUYURUTableAdapter();
            dt.DuyuruSil(id);
            Response.Redirect("DuyuruSil.Aspx");
        }
    }
}