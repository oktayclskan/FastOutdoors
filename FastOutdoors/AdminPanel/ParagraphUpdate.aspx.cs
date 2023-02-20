using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.AdminPanel
{
    public partial class ParagraphUpdate : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count !=0)
            {
                if (!IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["pid"]);
                    dll_category.DataTextField = "Name";
                    dll_category.DataValueField = "ID";
                    dll_category.DataSource = dm.CategoryList();
                    dll_category.DataBind();
                    Paragraphs p = dm.ParagraphgetGet(id);
                    dll_category.SelectedValue = p.Category_ID.ToString();
                    tb_title.Text = p.Title;
                    tb_content.Text = p.Contents;
                    img_paragraphimg.ImageUrl = "~/AdminPanel/Assets/Img/ParagraphsImages/" + p.Img;
                }
            }
            else
            {
                Response.Redirect("ParagraphList.aspx");
            }
        }
    }
}