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
    SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=kayıtlıkisiler;Integrated Security=True");



    protected void Button4_Click(object sender, EventArgs e)
    {

    }
    protected void Button4_Click1(object sender, EventArgs e)
    {
        if (TextBox9.Text == TextBox11.Text)
        {
            if (TextBox9.Text != "" && TextBox11.Text != "" && TextBox3.Text != "" && TextBox5.Text != "" && TextBox7.Text != "")
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from kisiler where Email='" + TextBox3.Text + "' ", baglan);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    baglan.Close();
                    baglan.Open();
                    SqlCommand cmd = new SqlCommand("update kisiler set Sifre='" + TextBox9.Text + "' where Email='" + TextBox3.Text + "'and  KullanıcıAdı='" + TextBox5.Text + "' and  Sifre='" + TextBox7.Text + "' ", baglan);
                    cmd.ExecuteNonQuery();




                    ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert(\n\n\n'Şifre Değiştirme Tamamlandı'); </script>");
                    TextBox7.Text = "";
                    TextBox5.Text = "";
                    TextBox9.Text = "";
                    TextBox11.Text = "";
                    TextBox3.Text = "";
                    baglan.Close();

                }
                else
                {

                    ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert(\n\n\n'Böyle Bir Kullanıcı Kayıtlı Değildir'); </script>");
                    baglan.Close();
                }
            }

            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert(\n\n\n'Lütfen Boş Alan Bırakmayınız'); </script>");
                baglan.Close();
            }

        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert(\n\n\n'İki Şifre Alanı Uyuşmuyor'); </script>");
            baglan.Close();

        }


    }
    protected void Button5_Click(object sender, EventArgs e)
    {


        if (TextBox4.Text != "" && TextBox6.Text != "" && TextBox8.Text != "")
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from kisiler where Email='" + TextBox4.Text + "' ", baglan);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                baglan.Close();
                baglan.Open();
                SqlCommand komut2 = new SqlCommand("Delete From kisiler where Sifre='"+TextBox8.Text+"'", baglan);
                komut2.ExecuteNonQuery();



                ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert(\n\n\n'Silme İşlemi Başarıyla Gerçekleşti'); </script>");
                TextBox4.Text = "";
                TextBox6.Text = "";
                TextBox8.Text = "";

                baglan.Close();

            }
            else
            {

                ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert(\n\n\n'Böyle Bir Kullanıcı Kayıtlı Değildir'); </script>");
                baglan.Close();
            }
        }

        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert(\n\n\n'Lütfen Boş Alan Bırakmayınız'); </script>");
            baglan.Close();
        }

    }
}
      
