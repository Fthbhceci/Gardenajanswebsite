using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtadsoyad.Text != "" && txtkadi.Text != "" && txtmail.Text != "" && txtsifre.Text != "")
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=kayıtlıkisiler;Integrated Security=True");

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into kisiler (AdSoyad,Email,KullanıcıAdı,Sifre) values('" + txtadsoyad.Text + "','" + txtmail.Text + "','" + txtkadi.Text + "','" + txtsifre.Text + "')", baglanti);

            cmd.ExecuteNonQuery();
            baglanti.Close();
            
          
            Label1.Text = "Kaydınız Başarılı Bir Şekilde Oluşturuldu";
            txtadsoyad.Text = "";
            txtkadi.Text = "";
            txtmail.Text = "";
            txtsifre.Text = "";
        }
        else
        {
            Label1.Text = "Lütfen Tüm Alanları Doldurun";
        
        }
        
    }
}