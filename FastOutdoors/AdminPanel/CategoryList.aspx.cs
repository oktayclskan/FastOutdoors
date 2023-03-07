using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.AdminPanel
{
    public partial class CategoryList : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_categoryList.DataSource = dm.CategoryList();
            lv_categoryList.DataBind();
        }

        protected void lv_categoryList_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "remove")
            {
                dm.CategoryDelete(id);
            }
            lv_categoryList.DataSource = dm.CategoryList();
            lv_categoryList.DataBind();



        }

    }
}