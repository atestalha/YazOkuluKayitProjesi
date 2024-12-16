using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["OGRID"]);
            DataSet1TableAdapters.TBLOGRTableAdapter dt = new DataSet1TableAdapters.TBLOGRTableAdapter();
            dt.OgrenciSil(id);
            Response.Redirect("Default.Aspx");
        }
    }
}