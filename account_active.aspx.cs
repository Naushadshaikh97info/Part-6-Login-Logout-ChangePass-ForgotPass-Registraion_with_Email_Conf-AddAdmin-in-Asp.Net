using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class account_active : System.Web.UI.Page
{
    DataClassesDataContext linq_obj = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;
        if (Request.QueryString["id"] != null)
        {
            var id = (from a in linq_obj.Registraion_msts
                      where a.intglcode == Convert.ToInt32(Request.QueryString["id"].ToString())
                      select a).Single();
            if (id.status == "Deactive")
            {
                id.status = "Active";
                linq_obj.SubmitChanges();
            }
        }
    }
}