using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.UserPanel
{
    public partial class UserLogin : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lbtn_logIn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_mail.Text) && !string.IsNullOrEmpty(tb_Password.Text))
            {
                Member m = dm.MemberLogin(tb_mail.Text,tb_Password.Text);
                if (m !=null)
                {
                    Session["Member"]= m;
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    pnl_eror.Visible = true;
                    lbl_eror.Text = "Mail veya Şifre Hatalı";
                }
            }
            else
            {
                pnl_eror.Visible = true;
                lbl_eror.Text = "Mail veya Şifre boş Bırakılmaz";
            }
        }
    }
}