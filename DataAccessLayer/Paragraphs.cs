using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Paragraphs
    {
        public int ID { get; set; }
        public int Category_ID { get; set; }
        public string CategoryName { get; set; }
        public int Admin_ID { get; set; }
        public string AdminName { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public int ParagraphViews { get; set; }
        public DateTime ParagraphDateTime { get; set; }
        public string ParagraphDateTimeStr { get; set; }
        public string Img { get; set; }
        public string Brief { get; set; }
    }
}
