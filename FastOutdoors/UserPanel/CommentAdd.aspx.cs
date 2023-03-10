using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using System.IO;

namespace FastOutdoors.UserPanel
{
    public partial class CommentAdd : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dll_category.DataTextField = "Name";
                dll_category.DataValueField = "ID";
                dll_category.DataSource = dm.CategoryList();
                dll_category.DataBind();
            }
        }

        protected void dll_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void lbtn_comment_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dll_category.SelectedItem.Value) != 0)
            {
                Comment c = new Comment();
                c.CommentViews = 0;
                c.CommentDate = DateTime.Now;
                Member m = (Member)Session["member"];
                c.Member_ID = m.ID;
                c.Category_ID = Convert.ToInt32(dll_category.SelectedItem.Value);
                c.Title = tb_title.Text;
                c.Content = tb_content.Text;
                c.CommentStatus = false;
                if (fu_Image.HasFile)
                {
                    FileInfo fi = new FileInfo(fu_Image.FileName);
                    if (fi.Extension == ".jpg" || fi.Extension == ".png")
                    {
                        string connect = fi.Extension;
                        string name = Guid.NewGuid().ToString();
                        c.Img = name + connect;
                        fu_Image.SaveAs(Server.MapPath("~/AdminPanel/Assets/Img/CommentImg/" + name + connect));
                        if (dm.CommentAdd(c))
                        {
                            dll_category.SelectedValue = "0";
                            tb_content.Text = " ";
                            tb_title.Text = " ";
                            pnl_eror.Visible = false;
                            pnl_successful.Visible = true;

                        }
                        else
                        {
                            pnl_eror.Visible = true;
                            pnl_successful.Visible = false;
                            lbl_eror.Text = "Yorum Ekleme Başarısız";
                        }
                    }
                    else
                    {
                        pnl_eror.Visible = true;
                        pnl_successful.Visible = false;
                        lbl_eror.Text = "Resim .png veya .jpg Olmalıdır";
                    }
                }
                else
                {
                    c.Img = "none.png";
                    if (dm.CommentAdd(c))
                    {
                        pnl_eror.Visible = false;
                        pnl_successful.Visible = true;
                        dll_category.SelectedValue = "0";
                        tb_content.Text = " ";
                        tb_title.Text = " ";
                    }
                    else
                    {
                        pnl_eror.Visible = true;
                        pnl_successful.Visible = false;
                        lbl_eror.Text = "Yorum Ekleme Başarısız";
                    }
                }
            }
            else
            {
                pnl_eror.Visible = true;
                pnl_successful.Visible = false;
                lbl_eror.Text = "Kategori seçimi yapmalısınız";
            }
        }
    }
}