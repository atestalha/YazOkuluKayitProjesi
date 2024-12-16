using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class NotListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.OGR_NOTTableAdapter dt = new DataSet1TableAdapters.OGR_NOTTableAdapter();
            Repeater1.DataSource = dt.NotListesi();
            Repeater1.DataBind();
        }
    }
}