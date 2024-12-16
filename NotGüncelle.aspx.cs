using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class NotGüncelle : System.Web.UI.Page
    {
        int nid;
        protected void Page_Load(object sender, EventArgs e)
        {
            nid = Convert.ToInt32(Request.QueryString["NOTID"]);
            DataSet1TableAdapters.OGR_NOTTableAdapter dt = new DataSet1TableAdapters.OGR_NOTTableAdapter();
            TxtOgrId.Text = dt.NotGetir2(nid)[0].OGRID.ToString();
            TxtOgrAdSoyad.Text = dt.NotGetir2(nid)[0].OGRENCIADISOYADI;
            TxtDersAd.Text = dt.NotGetir2(nid)[0].DERSAD.ToString();
            TxtSınav1.Text = dt.NotGetir2(nid)[0].SINAV1.ToString();
            TxtSınav2.Text = dt.NotGetir2(nid)[0].SINAV2.ToString();
            TxtSınav3.Text = dt.NotGetir2(nid)[0].SINAV3.ToString();
            TxtOrtalama.Text = dt.NotGetir2(nid)[0].ORTALAMA.ToString();
            TxtDurum.Text = dt.NotGetir2(nid)[0].DURUM.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            nid = Convert.ToInt32(Request.QueryString["NOTID"].ToString());
            DataSet1TableAdapters.OGR_NOTTableAdapter dt = new DataSet1TableAdapters.OGR_NOTTableAdapter();
            dt.NotGüncelle(byte.Parse(TxtSınav1.Text), byte.Parse(TxtSınav2.Text),
                byte.Parse(TxtSınav3.Text),
                decimal.Parse(TxtOrtalama.Text),
                bool.Parse(TxtDurum.Text), nid);
            Response.Redirect("NotGüncelle.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double sınav1, sınav2, sınav3, ortalama;
            sınav1 = Convert.ToInt32(TxtSınav1.Text);
            sınav2 = Convert.ToInt32(TxtSınav2.Text);
            sınav3 = Convert.ToInt32(TxtSınav3.Text);
            ortalama = (sınav1 + sınav2 + sınav3) / 3;
            TxtOrtalama.Text = ortalama.ToString("0.00");
            if (ortalama >= 50)
            {
                TxtDurum.Text = "True";
            }
            else
            {
                TxtDurum.Text = "False";
            }
        }
    }
}