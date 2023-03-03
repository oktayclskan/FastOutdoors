using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ComplaintSuggestion
    {
        public int ID { get; set; }
        public bool ComplaintSuggestionStatus { get; set; }
        public string ComplaintSuggestionStatusStr { get; set; }

        public string Content { get; set; }

    }
}
