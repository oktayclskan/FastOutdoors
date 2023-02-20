using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.AdminPanel
{
    public partial class Answers : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_answerList.DataSource = dm.AnswerList();
            lv_answerList.DataBind();
        }

        protected void lv_answerList_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "remove")
            {
                dm.DeleteAnswer(id);
            }
            lv_answerList.DataSource = dm.AnswerList();
            lv_answerList.DataBind();
        }
    }
}