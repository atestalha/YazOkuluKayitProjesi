using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class GelenMesajlar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLMESAJTableAdapter dt = new DataSet1TableAdapters.TBLMESAJTableAdapter();
            Repeater1.DataSource = dt.OgretmenMesajGetir();
            Repeater1.DataBind();
        }
    }
}