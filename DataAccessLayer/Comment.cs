using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Comment
    {
        public int ID { get; set; }
        public int Category_ID { get; set; }
        public string CategoryName { get; set; }
        public int Member_ID { get; set; }
        public string MemberName { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }
        public int CommentViews { get; set; }
        public bool CommentStatus { get; set; }
        public string CommentStatusStr { get; set; }
        public string Img { get; set; }
    }
}
