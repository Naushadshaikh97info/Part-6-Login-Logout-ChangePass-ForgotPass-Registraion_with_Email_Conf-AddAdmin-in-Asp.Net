using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddAdmin : System.Web.UI.Page
{
    DataClassesDataContext lnq_obj = new DataClassesDataContext();
    add_admin_mst login_obj = new add_admin_mst();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        if (IsPostBack)
            return;
        if (Request.QueryString["id"] == "1")
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "onload", "alert('**Admin Successfully Added**')", true);
        }
        fill_data(); 
    }
    private void clear()
    {
        txt_username.Text = "";
        txt_password.Text = "";
        txt_confrompasword.Text = "";
        ddl_role.SelectedIndex = 0;
    }
    private void fill_data()
    {
        var id = (from a in lnq_obj.add_admin_msts
                  orderby a.intglcode descending
                  select new
                  {
                      code = a.intglcode,
                      username = a.username,
                      role = a.role
                  }
                 ).ToList();
        GridView1.DataSource = id;
        GridView1.DataBind();
        if (id.Count == 0)
        {
            Page.RegisterStartupScript("onload", "<script language='javascript'>alert('**No Records to Show**')</script> ");
        }
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        try
        {
            login_obj.username = txt_username.Text;
            login_obj.password = base64Encode(txt_password.Text);
            login_obj.role = ddl_role.SelectedItem.Text;
            lnq_obj.add_admin_msts.InsertOnSubmit(login_obj);
            lnq_obj.SubmitChanges();
            clear();
            fill_data();
            Response.Redirect("AddAdmin.aspx?id=1", false);
        }
        catch (Exception ex)
        {


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
    protected void btn_cancel_Click(object sender, EventArgs e)
    {
        clear();
    }
}