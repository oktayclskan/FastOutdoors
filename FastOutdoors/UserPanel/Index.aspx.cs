using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.UserPanel
{
    public partial class Index : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString.Count == 0)
            {
                rp_paragraphs.DataSource = dm.ParagraphsList();
                rp_paragraphs.DataBind();
            }
        }
    }
}