using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Istatistik : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.DataTable1TableAdapter dt = new DataSet1TableAdapters.DataTable1TableAdapter();
            TextBox1.Text = "TOPLAM ÖĞRENCİ SAYISI: " + dt.Istatistik1().ToString();
            TextBox2.Text = "TOPLAM ÖĞRETMEN SAYISI: " + dt.Istatistik3().ToString();
            TextBox3.Text = "TOPLAM DERS SAYISI: " + dt.Istatistik2().ToString();
            TextBox4.Text = "MANTIK DEVRELERİ DERSİNDEN EN YÜKSEK PUAN ALAN ÖĞRENCİ: " + dt.Istatistik4().ToString();
            TextBox5.Text = "VERİ YAPILARI DERSİNDEN EN YÜKSEK PUAN ALAN ÖĞRENCİ : " + dt.Istatistik5().ToString();
            TextBox6.Text = "NESNEYE YÖNELİK PROGRAMLAMA DERSİNDEN EN YÜKSEK PUAN ALAN ÖĞRENCİ : " + dt.Istatistik6().ToString();
            TextBox7.Text = "PROGRAMLAMA DİLİ DERSİ SINAV1 ORTALAMASI: " + dt.Istatistik7().ToString();
            TextBox8.Text = "İSTATİSTİK VE OLASILIK DERSİ SINAV1 ORTALAMASI: " + dt.Istatistik8().ToString();
            TextBox9.Text = "İŞLETİM SİSTEMLERİ DERSİ SINAV1 ORTALAMASI: " + dt.Istatistik9().ToString();
            TextBox10.Text = "PROGRAMLAMA DİLİ DERSİ SINAV2 ORTALAMASI: " + dt.Istatistik10().ToString();
            TextBox11.Text = "İSTATİSTİK VE OLASILIK DERSİ SINAV2 ORTALAMASI: " + dt.Istatistik11().ToString();
            TextBox12.Text = "İŞLETİM SİSTEMLERİ DERSİ SINAV2 ORTALAMASI:" + dt.Istatistik12().ToString();
        }
    }
}