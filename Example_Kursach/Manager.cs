using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach
{
    public class Manager
    {
        public List<DBUser> UsersList { get; set; }

        public Manager()
        {
            UsersList = new List<DBUser>
            {
                new DBUser("dbadmin1", "8888"),
                new DBUser("dbadmin2", "9999"),
                new DBUser("dbadmin3", "0000")
            };
        }
    }
}
