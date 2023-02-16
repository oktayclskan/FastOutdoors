using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Admin
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string AdminPassword { get; set; }
        public bool AdminStatus { get; set; }
        public string AdminStatusStr { get; set; }

    }
}
