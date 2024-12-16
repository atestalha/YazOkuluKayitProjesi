using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Log : System.Web.UI.Page
    {
        SqlConnection baglan = new SqlConnection("Data Source=ATES\\SQLEXPRESS;Initial Catalog=DB_Yaz_Okulu;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


        }
    
    }
}


