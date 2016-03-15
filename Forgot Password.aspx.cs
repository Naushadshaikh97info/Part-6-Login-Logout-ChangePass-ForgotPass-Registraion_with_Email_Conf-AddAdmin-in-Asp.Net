using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class Forgot_Password : System.Web.UI.Page
{
    DataClassesDataContext linq_obj = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        var id = (from a in linq_obj.Registraion_msts
                  where a.EmailID == txt_email_id.Text
                  select a).ToList();
        if (id.Count() == 1)
        {
            try
            {
                SmtpClient smtpclient;
                MailMessage message;
                string str23 = "Username is: " + id[0].UserName + " and Password is: " + base64Decode(id[0].Password) + " MobileNo;" + id[0].MobileNo;
                smtpclient = new SmtpClient();
                message = new MailMessage();
                try
                {
                    message.From = new MailAddress("acerelocation001@gmail.com");
                    message.To.Add(id[0].EmailID);  //send email to yahoo
                    message.Subject = "Forgot Password";
                    message.Body = str23;
                    smtpclient.Host = "smtp.gmail.com";
                    smtpclient.EnableSsl = true;
                    smtpclient.UseDefaultCredentials = true;
                    System.Net.NetworkCredential network = new System.Net.NetworkCredential();
                    network.UserName = "acerelocation001@gmail.com"; // moksha mail
                    network.Password = "Ace12345"; //password
                    smtpclient.UseDefaultCredentials = true;
                    smtpclient.Credentials = network;
                    smtpclient.Port = 25;
                    smtpclient.Send(message);
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                ScriptManager.RegisterStartupScript(this, GetType(), "onload", "alert('**  Your Password is Successfully Send to Your Email**')", true);
            }
            catch (Exception ex)
            {
                
            }
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "onload", "alert('**  Enter Your right Email**')", true);
        }
    }
    public string base64Decode(string sData)
    {

        System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();

        System.Text.Decoder utf8Decode = encoder.GetDecoder();

        byte[] todecode_byte = Convert.FromBase64String(sData);

        int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);

        char[] decoded_char = new char[charCount];

        utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);

        string result = new String(decoded_char);

        return result;
    }
    
}