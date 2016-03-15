using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            Label1.Text = Session["username"].ToString();
            Label2.Text = Session["id"].ToString();
        }
        else
        {
            Response.Redirect("Alogin.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        {
            Session["username"] = "";
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}