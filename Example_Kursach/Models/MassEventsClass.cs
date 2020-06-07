using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class MassEventsClass
    {
        public int TariffID { get; set; }
        public int MaxHours { get; set; }
        public int Shifts { get; set; }
        public string MinPrice { get; set; }
        public string Description { get; set; }

        public MassEventsClass(int tar, int maxh, int shifts, string mPrice, string desc)
        {
            TariffID = tar;
            MaxHours = maxh;
            Shifts = shifts;
            MinPrice = mPrice;
            Description = desc;

        }
    }
}
