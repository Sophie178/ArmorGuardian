using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class OfficeClass
    {

        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public OfficeClass(string address, string phone)
        {
            Address = address;
            PhoneNumber = phone;
        }

    }
}
