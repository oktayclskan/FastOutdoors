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
    public partial class CategoryAdd : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_categoryAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_name.Text.Trim()))
            {
                if (dm.CategoryControl(tb_name.Text.Trim()))
                {
                    Category c = new Category();
                    c.Name = tb_name.Text;
                    if (fu_Image.HasFile)
                    {
                        FileInfo fi = new FileInfo(fu_Image.FileName);
                        if (fi.Extension == ".jpg" || fi.Extension == ".png")
                        {
                            string extension = fi.Extension;
                            string name = Guid.NewGuid().ToString();
                            c.Img = name + extension;
                            fu_Image.SaveAs(Server.MapPath("~/AdminPanel/Assets/Img/" + name + extension));
                            if (dm.CategoryAdd(c))
                            {
                                tb_name.Text = " ";
                                pnl_successful.Visible = true;
                                pnl_eror.Visible = false;
                            }
                            else
                            {
                                pnl_successful.Visible = false;
                                pnl_eror.Visible = true;
                                lbl_eror.Text = "Kategori ekleriken bir hata oluştu";
                            }
                        }
                        else
                        {
                            pnl_successful.Visible = false;
                            pnl_eror.Visible = true;
                            lbl_eror.Text = "Resim uzantısı sadece .jpg veya png olmalıdır";
                        }
                    }
                    else
                    {
                        c.Img = "none.png";
                        if (dm.CategoryAdd(c))
                        {
                            pnl_eror.Visible = false;
                            pnl_successful.Visible = true;
                            tb_name.Text = " ";
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
                    pnl_successful.Visible = false;
                    pnl_eror.Visible = true;
                    lbl_eror.Text = "Bu kategori daha önce eklenmiş";
                }

            }
            else
            {
                pnl_eror.Visible = true;
                lbl_eror.Text = "Isim Boş Bırakılamaz";
            }
        }
    }
}