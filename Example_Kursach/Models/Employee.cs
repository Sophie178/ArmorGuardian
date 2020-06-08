using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class Employee
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }
        public int DepID { get; set; }
        public string Position { get; set; }

        public Employee(string surname, string name, DateTime dob, string pos, string phoneNumber, string address,
            string email, int dep, int room)
        {
            Surname = surname;
            Name = name;
            DoB = dob;
            Position = pos;
            PhoneNumber = phoneNumber;
            Address = address;
            Email = email;
            DepID = dep;
            Room = room;
        }
    }
}
