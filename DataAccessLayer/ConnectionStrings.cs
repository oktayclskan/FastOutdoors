using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ConnectionStrings
    {
        public static string desktopComputer = @"Data Source=DESKTOP-9FP6GB0\SQLEXPRESS; Initial Catalog=FastOutdoorsDB;Integrated Security=True";
        public static string Laptop = @"Data Source=; Initial Catalog=FastOutdoorsDB;Integrated Security=True";
    }
}
