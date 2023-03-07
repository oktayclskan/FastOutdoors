using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.AdminPanel
{
    public partial class ComplaintSuggestionList : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_toBeRead.Visible = true;
            lv_toBeRead.DataSource = dm.ComplaintSuggestionList(0);
            lv_toBeRead.DataBind();
        }

        protected void lv_read_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "remove")
            {
                lv_toBeRead.Visible = false;
                dm.ComplaintSuggestionDelete(id);
                lv_read.DataSource = dm.ComplaintSuggestionList(1);
                lv_read.DataBind();

                
            }
        }

        protected void lv_toBeRead_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Read")
            {
                dm.ComplaintSuggestionRead(id);
                lv_toBeRead.DataSource = dm.ComplaintSuggestionList(0);
                lv_toBeRead.DataBind();
            }
        }

        protected void lbtn_read_Click(object sender, EventArgs e)
        {
            lv_read.Visible = true;
            lv_toBeRead.Visible = false;
            lv_read.DataSource = dm.ComplaintSuggestionList(1);
            lv_read.DataBind();
        }

        protected void lbtn_toBeRead_Click(object sender, EventArgs e)
        {
            lv_toBeRead.Visible = true;
            lv_read.Visible = false;
            lv_toBeRead.DataSource = dm.ComplaintSuggestionList(0);
            lv_toBeRead.DataBind();
        }
    }
}