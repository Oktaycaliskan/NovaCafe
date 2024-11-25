using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ConnectionStrings
    {
        public static string ConStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=NovaCafe_DB;Integrated Security=True";
    }
    public class Admin
    {
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
    }
}
