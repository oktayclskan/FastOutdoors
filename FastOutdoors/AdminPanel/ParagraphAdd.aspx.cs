using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using System.IO;

namespace FastOutdoors.AdminPanel
{
    public partial class ParagraphAdd : System.Web.UI.Page
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


        protected void lb_Add_Click1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dll_category.SelectedItem.Value) != 0)
            {
                Paragraphs p = new Paragraphs();
                p.ParagraphViews = 0;
                p.ParagraphDateTime = DateTime.Now;
                Admin a = (Admin)Session["admin"];
                p.Admin_ID = a.ID;
                p.Category_ID = Convert.ToInt32(dll_category.SelectedItem.Value);
                p.Title = tb_title.Text;
                p.Contents = tb_content.Text;
                if (fu_Image.HasFile)
                {
                    FileInfo fi = new FileInfo(fu_Image.FileName);
                    if (fi.Extension == ".jpg" || fi.Extension == ".png")
                    {
                        string connect = fi.Extension;
                        string name = Guid.NewGuid().ToString();
                        p.Img = name + connect;
                        fu_Image.SaveAs(Server.MapPath("~/AdminPanel/Assets/Img/ParagraphsImages/" + name + connect));
                        if (dm.ParagraphAdd(p))
                        {
                            pnl_eror.Visible = false;
                            pnl_successful.Visible = true;

                        }
                        else
                        {
                            pnl_eror.Visible = true;
                            pnl_successful.Visible = false;
                            lbl_eror.Text = "Metin Ekleme Başarısız";
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
                    pnl_eror.Visible = true;
                    pnl_successful.Visible = false;
                    lbl_eror.Text = "Resim seçimi yapmalısınız";
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