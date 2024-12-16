using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DefaultOgrenci : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // TextBox1.Text = Request.QueryString["OGRNUMARA"];
            DataSet1TableAdapters.TBLOGRTableAdapter dt = new DataSet1TableAdapters.TBLOGRTableAdapter();
            TextBox2.Text = "Ad-Soyad: " + dt.OgrenciPaneli(TextBox2.Text)[0].OGRAD + " " + dt.OgrenciPaneli(TextBox2.Text)[0].OGRSOYAD;
            TextBox3.Text = "Telefon: " + dt.OgrenciPaneli(TextBox3.Text)[0].OGRTELEFON;
            TextBox4.Text = "Şifre: " + dt.OgrenciPaneli(TextBox4.Text)[0].OGRSIFRE;
            TextBox5.Text = "Mail: " + dt.OgrenciPaneli(TextBox5.Text)[0].OGRMAIL;
        }
    }
}