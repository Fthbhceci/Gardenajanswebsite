using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net.Mail;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btngonder_Click(object sender, EventArgs e)
    {

            MailMessage mesajım = new MailMessage();
        SmtpClient istemci = new SmtpClient();
        istemci.Credentials = new System.Net.NetworkCredential("fthbhceci@outlook.com", "10sosyala.");
        istemci.Port = 587;
        istemci.Host = "smtp-mail.outlook.com";
        istemci.EnableSsl = true;
        mesajım.To.Add("fthbhceci@outlook.com");
        mesajım.From = new MailAddress("fthbhceci@outlook.com");
        mesajım.Subject = txtkonu.Text;
        mesajım.Body = txtadsoyad.Text +"   "+ txtmail.Text +"   "  + txttelefon.Text + "     \n \n \n" + txtacıklama.Text;
        istemci.Send(mesajım);
        ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert(\n\n\n'Mailiniz Alınmıştır Teşekkür Ederiz'); </script>")
        ; txtacıklama.Text = "";
        txtadsoyad.Text = "";
        txtkonu.Text = "";
        txtmail.Text = "";
        txttelefon.Text = "";
    }
    protected void txtmail_TextChanged(object sender, EventArgs e)
    {

    }
}