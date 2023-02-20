using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.AdminPanel
{
    public partial class ParagraphList : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_paragrapList.DataSource = dm.ParagraphsList();
            lv_paragrapList.DataBind();
        }

        protected void lv_paragrapList_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "remove")
            {
                dm.DeleteParagraph(id);
            }
            lv_paragrapList.DataSource = dm.ParagraphsList();
            lv_paragrapList.DataBind();
        }
    }
}