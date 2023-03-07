using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.UserPanel
{
    public partial class ComplaintSuggestionPages : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_send_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_content.Text.Trim()))
            {
                ComplaintSuggestion cs = new ComplaintSuggestion();
                cs.Content = tb_content.Text;
                cs.ComplaintSuggestionStatus = false;
                if (dm.ComplaintSuggestionAdd(cs))
                {
                    tb_content.Text = "  ";
                    pnl_succes.Visible = true;
                    pnl_eror.Visible = false;
                }
                else
                {
                    pnl_succes.Visible = false;
                    pnl_eror.Visible = true;
                    lbl_msj.Text = "Yorum ekleme Başarırsız";
                }
            }
            else
            {
                pnl_succes.Visible = false;
                pnl_eror.Visible = true;
                lbl_msj.Text = "Lütfen şikayet alanını doldurunuz";
            }
        }
    }
}