using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.AdminPanel
{
    public partial class ParagraphDetail : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count != 0)
            {
                int id = Convert.ToInt32(Request.QueryString["pid"]);
                Paragraphs p = dm.ParagraphgetGet(id);
                img_images.ImageUrl = "../AdminPanel/Assets/Img/ParagraphsImages/" + p.Img;
                ltrl_title.Text = p.Title;
                ltrl_brief.Text = p.Brief;
                ltrl_content.Text = p.Contents;
                ltrl_views.Text = p.ParagraphViews.ToString();
                ltrl_dateTime.Text = p.ParagraphDateTime.ToLongDateString();
            }
        }
    }
}