using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.UserPanel
{
    public partial class FormPage : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count == 0)
            {
                rp_Comments.DataSource = dm.CommentList(1);
                rp_Comments.DataBind();

                if (Session["member"] !=null)
                {
                    pnl_LoggedIn.Visible = true;
                    pnl_noEntry.Visible = false;
                }
                else
                {
                    pnl_LoggedIn.Visible = false;
                    pnl_noEntry.Visible = true;
                }
            }
        }
    }
}