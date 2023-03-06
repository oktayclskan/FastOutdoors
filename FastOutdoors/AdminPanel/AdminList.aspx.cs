using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.AdminPanel
{
    public partial class AdminList : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_adminListActive.DataSource = dm.AdminList(1);
            lv_adminListActive.DataBind();
        }
        protected void lv_adminListActive_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "deactivate")
            {
                dm.AdminStatusPassive(id);
            }
            lv_adminListActive.DataSource = dm.AdminList(1);
            lv_adminListActive.DataBind();

        }

        protected void lv_AdminListsPassive_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "remove")
            {
                dm.AdminRemove(id);
            }
            if (e.CommandName == "activate")
            {
                dm.AdminStatusActive(id);
            }
            lv_AdminListsPassive.DataSource = dm.AdminList(0);
            lv_AdminListsPassive.DataBind();
        }
        protected void lbtn_activeAdmBtn_Click(object sender, EventArgs e)
        {
            lv_adminListActive.DataSource = dm.AdminList(1);
            lv_adminListActive.DataBind();
            lv_adminListActive.Visible = true;
            lv_AdminListsPassive.Visible = false;
        }

        protected void lbtn_passiveAdmnBtn_Click(object sender, EventArgs e)
        {
            lv_AdminListsPassive.DataSource = dm.AdminList(0);
            lv_AdminListsPassive.DataBind();
            lv_adminListActive.Visible = false;
            lv_AdminListsPassive.Visible = true;
        }
    }
}