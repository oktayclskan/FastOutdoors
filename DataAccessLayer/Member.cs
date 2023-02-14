using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string MemberPassword{ get; set; }
        public string Location{ get; set; }
        public bool MemberStatus{ get; set; }
        public string MemberStatusStr { get; set; }
    }
}
