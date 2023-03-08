using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Answers
    {
        public int ID { get; set; }
        public int Comment_ID { get; set; }
        public int Member_ID { get; set; }
        public string MemberName { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public DateTime AnswersTime { get; set; }
        
    }
}
