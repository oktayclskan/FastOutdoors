using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.AdminPanel
{
    public partial class CommentsList : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_commentWaiting.Visible = true;
            lv_commentWaiting.DataSource = dm.CommentList(0);
            lv_commentWaiting.DataBind();
        }
        protected void lv_commentApproved_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "remove")
            {
                dm.CommentDelete(id);
                lv_commentApproved.DataSource = dm.CommentList(1);
                lv_commentApproved.DataBind();
            }
        }

        protected void lv_commentWaiting_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "remove")
            {
                dm.CommentDelete(id);
            }
            if (e.CommandName == "approve")
            {
                dm.CommentApprove(id);
               
            }
            lv_commentWaiting.DataSource = dm.CommentList(0);
            lv_commentWaiting.DataBind();
        }

        protected void lbtn_approved_Click(object sender, EventArgs e)
        {
            lv_commentApproved.DataSource = dm.CommentList(1);
            lv_commentApproved.DataBind();
            lv_commentApproved.Visible = true;
            lv_commentWaiting.Visible = false;
        }

        protected void lbtn_waiting_Click(object sender, EventArgs e)
        {
            lv_commentWaiting.DataSource = dm.CommentList(0);
            lv_commentWaiting.DataBind();
            lv_commentApproved.Visible = false;
            lv_commentWaiting.Visible = true;
        }
    }
}