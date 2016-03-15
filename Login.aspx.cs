using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    DataClassesDataContext lnq_obj = new DataClassesDataContext();
    static int flag = 0;    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        var id = (from a in lnq_obj.Registraion_msts
                  select a).ToList();
        for (int i = 0; i < id.Count; i++)
        {
            if (id[i].UserName == txt_username.Text && base64Decode(id[i].Password) == txt_password.Text)
            {
                flag = 1;
                Session["username"] = txt_username.Text;
                Session["id"] = id[i].intglcode;
                break;
            }
        }
        if (flag == 1)
        {
            Response.Redirect("Logout.aspx");
        }
        else
        {
            Page.RegisterStartupScript("onload","<script language='javascript'>alert('**Incorect UserName or Password**')</script>");
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