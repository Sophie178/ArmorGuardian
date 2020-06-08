using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class NPClientClass
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int PSeries{ get; set; }
        public int PassNumber { get; set; }

        public NPClientClass(string name, string surname, DateTime dob, string phoneNumber, string address,
            string email, int pseries, int passnumber)
        {
            Surname = surname;
            Name = name;
            DoB = dob;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            PSeries = pseries;
            PassNumber = passnumber;
        }
    }
}
