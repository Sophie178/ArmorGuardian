using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class FacilityClass
    {
        public int TariffID { get; set; }
        public int HoursPerDay { get; set; }
        public string MinPricePerPost { get; set; }
        public int Armed { get; set; }
        public int MinPostQuantity { get; set; }
        public string Description { get; set; }

        public FacilityClass(int tar, int hours, string minP, int armed, int mpquantity, string desc)
        {
            TariffID = tar;
            HoursPerDay = hours;
            MinPricePerPost = minP;
            Armed = armed;
            Description = desc;
            MinPostQuantity = mpquantity;
            Description = desc;
        }

    }
}
