using System;
using System.Collections.Generic;
using System.IO;
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
                    tb_brief.Text = p.Brief;
                    img_paragraphimg.ImageUrl = "~/AdminPanel/Assets/Img/ParagraphsImages/" + p.Img;
                }
            }
            else
            {
                Response.Redirect("ParagraphList.aspx");
            }
        }

        protected void lb_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["pid"]);
            Paragraphs p = dm.ParagraphgetGet(id);
            p.Category_ID = Convert.ToInt32(dll_category.SelectedItem.Value);
            p.Title = tb_title.Text;
            p.Contents = tb_content.Text;
            p.Brief = tb_brief.Text;

            if (fu_Image.HasFile)
            {
                FileInfo fi = new FileInfo(fu_Image.FileName);
                if (fi.Extension == ".jpg" || fi.Extension == ".png")
                {
                    string connect = fi.Extension;
                    string name = Guid.NewGuid().ToString();
                    p.Img = name + connect;
                    fu_Image.SaveAs(Server.MapPath("~/AdminPanel/Assets/Img/ParagraphsImages/" + name + connect));
                }
                else
                {
                    pnl_eror.Visible = true;
                    pnl_successful.Visible = false;
                    lbl_eror.Text = "Resim .png veya .jpg Olmalıdır";
                }
                
            }
            if (dm.ParagraphUpdate(p))
            {
                pnl_eror.Visible = false;
                pnl_successful.Visible = true;
                tb_title.Text = tb_content.Text = "";
                dll_category.SelectedValue = "0";
            }
            else
            {
                pnl_eror.Visible = true;
                pnl_successful.Visible = false;
                lbl_eror.Text = "Metin düzenleme Başarısız";
            }
        }
    }
}