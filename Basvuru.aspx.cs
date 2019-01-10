using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != "" && TextBox8.Text != "" && TextBox9.Text != "" && TextBox10.Text != "" && TextBox11.Text != "" && TextBox12.Text != "" && TextBox13.Text != "" && TextBox14.Text != "" && TextBox15.Text != "" && TextBox16.Text != "" && TextBox17.Text != "" && TextBox18.Text != "")
        {
            if (TextBox4.Text == TextBox7.Text)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert(\n\n\n'Başvurunuz Alınmıştır Teşekkür Ederiz'); </script>");
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                TextBox10.Text = "";
                TextBox11.Text = "";
                TextBox12.Text = "";
                TextBox13.Text = "";
                TextBox14.Text = "";
                TextBox15.Text = "";
                TextBox16.Text = "";
                TextBox17.Text = "";
                TextBox18.Text = "";

              
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert(\n\n\n'E-mail Alanlarınız Uyuşmuyor Kontrol Ediniz'); </script>");

            }
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert(\n\n\n'Lütfen Boş Alan Bırakmayınız'); </script>");
        }
    }
}