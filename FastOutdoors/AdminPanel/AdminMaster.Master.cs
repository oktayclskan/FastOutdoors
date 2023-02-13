using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.AdminPanel
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"]!=null)
            {
                Admin a = (Admin)Session["Admin"];
                lb_loginName.Text = $"{a.Name} {a.SurName}";
            }
            else
            {
                Response.Redirect("AdminLogin.aspx");
            }
        }

        protected void lbtn_exit_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }
    }
}