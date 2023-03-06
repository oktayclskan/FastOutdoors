﻿using System;
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
            if (Request.QueryString.Count !=0)
            {
                int id = Convert.ToInt32(Request.QueryString["fid"]);
                Comment c = dm.CommentGet(id);
                ltrl_title.Text = c.Title;
                ltrl_content.Text = c.Content;
                ltrl_dateTime.Text = c.CommentDate.ToLongDateString();
                Answers a = dm.AnswersGet(id);
                ltrl_AmemberName.Text = a.MemberName;
                ltrl_AContent.Text = a.Content;
            }
        }
    }
}