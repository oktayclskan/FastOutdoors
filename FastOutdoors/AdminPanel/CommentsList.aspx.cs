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
            lv_commentList.DataSource = dm.CommentList();
            lv_commentList.DataBind();

        }

        protected void lv_commentList_ItemCommand(object sender, ListViewCommandEventArgs e)
        {

        }
    }
}