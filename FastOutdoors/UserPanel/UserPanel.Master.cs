using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.UserPanel
{
    public partial class UserPanel : System.Web.UI.MasterPage
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["member"] !=null)
            {
                pnl_loggedIn.Visible = true;
                pnl_noEntry.Visible = false;
                Member m = (Member)Session["member"];
                lbl_memberName.Text =m.Name + "  " + m.SurName + "("+m.UserName +")";
            }
            else
            {
                pnl_loggedIn.Visible = false;
                pnl_noEntry.Visible = true;
            }
        }

        protected void lbtb_exit_Click(object sender, EventArgs e)
        {
            Session["member"]= null;
            Response.Redirect("Index.aspx");
        }
    }
}