using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class Registarion : System.Web.UI.Page
{

    DataClassesDataContext lnq_obj = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;
        fill_data();
    }
    private void fill_data()
    {
        var id = (from a in lnq_obj.Registraion_msts
                  orderby a.intglcode descending
                  select new
                  {
                      code = a.intglcode,
                      name = a.Name,
                      surname = a.SurName,
                      username = a.UserName,
                      password = a.Password,
                      emailid = a.EmailID,
                      mobileno = a.MobileNo
                  }).ToList();
        GridView1.DataSource = id;
        GridView1.DataBind();




    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        lnq_obj.insert_Rgistraion(txt_name.Text, txt_surname.Text, txt_username.Text, base64Encode(txt_password.Text), txt_emailid.Text, txt_mobileno.Text, "Deactive");
        lnq_obj.SubmitChanges();
        fill_data();



        var id = (from a in lnq_obj.Registraion_msts
                   orderby a.intglcode descending
                   select a).ToList();
        if (id.Count() != 0)
        {
            try
            {
                SmtpClient smtpclient;
                MailMessage message;
                string str23 = "Activation Link  " + "http://localhost:1334/Part_5_Login,Logout,ForgotPassword,ChangePassword,ForgotPassword,Registraion_with_Email_Confirmation,AddAdmin/account_active.aspx?id=" + id[0].intglcode;

                smtpclient = new SmtpClient();
                message = new MailMessage();
                try
                {
                    message.From = new MailAddress("naushadsoftware97@gmail.com");
                    message.To.Add(id[0].EmailID);  //send email to yahoo
                    message.Subject = "Account Activation";
                    message.Body = str23;
                    smtpclient.Host = "smtp.gmail.com";
                    smtpclient.EnableSsl = true;
                    smtpclient.UseDefaultCredentials = true;
                    System.Net.NetworkCredential network = new System.Net.NetworkCredential();
                    network.UserName = "naushadsoftware97@gmail.com"; // moksha mail
                    network.Password = "efghEFGH1234!@#$"; //password
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
            ScriptManager.RegisterStartupScript(this, GetType(), "onload", "alert('**Enter Your right Email**')", true);
        }
    }

    private string base64Encode(string sData)
    {
        try
        {
            byte[] encData_byte = new byte[sData.Length];

            encData_byte = System.Text.Encoding.UTF8.GetBytes(sData);

            string encodedData = Convert.ToBase64String(encData_byte);

            return encodedData;

        }
        catch (Exception ex)
        {
            throw new Exception("Error in base64Encode" + ex.Message);
        }
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fill_data();
    }
}