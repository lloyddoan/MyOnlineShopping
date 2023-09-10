using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    DS_USER.USER_SELECTDataTable UDT = new DS_USER.USER_SELECTDataTable();
    DS_USERTableAdapters.USER_SELECTTableAdapter UAdapter = new DS_USERTableAdapters.USER_SELECTTableAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        //UDT = UAdapter.Seleect_FOR_LOGIN(txtuname.Text, txtpass.Text);
        
        if (txtuname.Text == "user" && txtpass.Text == "1234")
        {
            Session["uname"] = txtuname.Text;
            Session["fname"] = "customer1";
            Session["lname"] = "1";
            Response.Redirect("User/Default.aspx");
        }
        else
        {
       
            lblerror.Text = "Error !!!";
        }
    }
}