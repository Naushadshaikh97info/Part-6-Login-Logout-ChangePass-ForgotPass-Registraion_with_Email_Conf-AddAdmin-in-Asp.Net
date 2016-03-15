using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChangePassword : System.Web.UI.Page
{
    DataClassesDataContext lnq_obj = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["name"] == null)    
        {
            Response.Redirect("Login.aspx");
        }
        if (IsPostBack)
            return;
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        int code = Convert.ToInt32(Session["id"].ToString());

        var id = (from a in lnq_obj.Registraion_msts
                  where a.intglcode == code
                  select a).Single();
        if (id.Password == base64Encode(txt_oldpassword.Text))
        {
            id.Password = base64Encode(txt_newpassword.Text);
            lnq_obj.SubmitChanges();
            Page.RegisterStartupScript("onload", "<script language='javascript'>alert('**Your Pasword Succesfully Change**')</script>");
        }
        else
        {
            Page.RegisterStartupScript("onload", "<script language='javascript'>alert('**Your Old Password Not Correct**')</script>");
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
}