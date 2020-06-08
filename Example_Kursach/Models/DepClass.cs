using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class DepClass
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }
        public int OfficeID { get; set; }
        public int Floor { get; set; }

        public DepClass(string name, string phNumber, int office, int floor)
        {
            Name = name;
            PhoneNumber = phNumber;
            OfficeID = office;
            Floor = floor;
        }
    }
}
