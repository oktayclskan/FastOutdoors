using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.UserPanel
{
    public partial class FormRead : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count != 0)
            {
                int id = Convert.ToInt32(Request.QueryString["fid"]);
                Comment c = dm.CommentGet(id);
                ltrl_title.Text = c.Title;
                img_images.ImageUrl = "../AdminPanel/Assets/Img/CommentImg/" + c.Img;
                ltrl_content.Text = c.Content;
                ltrl_dateTime.Text = c.CommentDate.ToLongDateString();
                lv_answer.DataSource = dm.AnswersGet(id);
                lv_answer.DataBind();


            }
        }

        protected void lv_answer_ItemCommand(object sender, ListViewCommandEventArgs e)
        {

        }

        protected void lbtn_AddAnswer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_answerAdd.Text.Trim()))
            {
                Answers a = new Answers();
                a.AnswersTime = DateTime.Now;
                Member m = (Member)Session["member"];
                a.Member_ID = m.ID;
                a.Comment_ID = Convert.ToInt32(Request.QueryString["fid"]);
                a.Content = tb_answerAdd.Text;
                if (dm.AnswerAdd(a))
                {
                    pnlEror.Visible = false;
                }
                else
                {
                    pnlEror.Visible = true;
                    lbl_erorMsg.Text = "Yorum ekleme Başarısız";
                }
                
            }
            else
            {
                pnlEror.Visible = true;
                lbl_erorMsg.Text = "Yorum kısmını doldurmadan yorum ekleyemesiniz";
            }
        }
    }
}