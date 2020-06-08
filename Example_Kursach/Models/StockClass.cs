using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class StockClass
    {
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int Office { get; set; }
        public StockClass(string address, string phone, int office)
        {
            Address = address;
            PhoneNumber = phone;
            Office = office;
        }

    }
}
