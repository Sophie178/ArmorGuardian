using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class Guard
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int LRank { get; set; }
        public DateTime License { get; set; }
        public int UnitID { get; set; }
        public string Position { get; set; }

        public Guard(string surname, string name, DateTime dob, string address, string phoneNumber,
            int rank, DateTime license, int unit, string pos)
        {
            Surname = surname;
            Name = name;
            DoB = dob;
            Address = address;
            PhoneNumber = phoneNumber;
            LRank = rank;
            License = license;
            UnitID = unit;
            Position = pos;
        }
    }
}
