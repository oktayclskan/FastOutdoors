using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.AdminPanel
{
    public partial class MemberList : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_memberList.DataSource = dm.MemberList();
            lv_memberList.DataBind();
        }

        protected void lv_memberList_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            
            if (e.CommandName == "ban")
            {
                dm.MemberBan(id);
            }
            if (e.CommandName == "unban")
            {
                dm.MemberUnBan(id);
            }
            if (e.CommandName == "remove")
            {
                dm.MemberDelete(id);
                
            }
            lv_memberList.DataSource = dm.MemberList();
            lv_memberList.DataBind();
        }
    }
}