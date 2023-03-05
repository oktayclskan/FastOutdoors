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
    public partial class CategoryUpdate : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count != 0)
            {
                if (!IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["cid"]);
                    Category c = dm.CategoryGet(id);
                    tb_name.Text = c.Name;
                    img_categoryImg.ImageUrl = "~/AdminPanel/Assets/Img/" + c.Img;
                }
            }
            else
            {
                Response.Redirect("CategoryList.aspx");
            }
        }

        protected void lbtn_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["cid"]);
            Category c = dm.CategoryGet(id);
            c.Name = tb_name.Text;
            if (fu_Image.HasFile)
            {
                FileInfo fi = new FileInfo(fu_Image.FileName);
                if (fi.Extension == ".jpg" || fi.Extension == ".png")
                {
                    string connect = fi.Extension;
                    string name = Guid.NewGuid().ToString();
                    c.Img = name + connect;
                    fu_Image.SaveAs(Server.MapPath("~/AdminPanel/Assets/Img/" + name + connect));
                }
                else
                {
                    pnl_eror.Visible = true;
                    pnl_successful.Visible = false;
                    lbl_eror.Text = "Resim .png veya .jpg Olmalıdır";
                }
            }
            if (dm.CategoryUpdate(c))
            {
                pnl_eror.Visible = false;
                pnl_successful.Visible = true;
                tb_name.Text = " ";

            }
            else
            {
                pnl_eror.Visible = true;
                pnl_successful.Visible = false;
                lbl_eror.Text = "Kategori düzenleme Başarısız";
            }
        }
    }
}