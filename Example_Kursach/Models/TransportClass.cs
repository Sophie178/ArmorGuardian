using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class TransportClass
    {
        public int TransportID { get; set; }
        public string Model { get; set; }
        public int Seats { get; set; }
        public int ArmorPlating { get; set; }
        public string CarBodyStyle { get; set; }
        public int ManufactureYear { get; set; }
        public int CIT { get; set; }

        public TransportClass(int trID, string model, int seats, int armor, string carStyle, int year, int cit)
        {
            TransportID = trID;
            Model = model;
            Seats = seats;
            ArmorPlating = armor;
            CarBodyStyle = carStyle;
            ManufactureYear = year;
            CIT = cit;
        }

    }
}
