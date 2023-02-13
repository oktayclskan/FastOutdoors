using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.AdminPanel
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_singIn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_mail.Text) && !string.IsNullOrEmpty(tb_password.Text))
            {
                Admin a = dm.AdminLogin(tb_mail.Text,tb_password.Text);
                if (a !=null)
                {
                    Session["Admin"] = a;
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    pnl_eror.Visible = true;
                    lbl_eror.Text = "Mail veye Sifre Hatalı";
                }
            }
            else
            {
                pnl_eror.Visible = true;
                lbl_eror.Text = "Mail veye Sifre Boş Bırakılamaz";
            }
        }
    }
}