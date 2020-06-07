using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach
{
    public class DBUser
    {
        public string Login { get; set; }
        public string Password { get; set; }


        public DBUser(string login, string password)
        {
            Login = login;
            Password = password;
        }
        
    }
}
