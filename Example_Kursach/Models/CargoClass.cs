using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class CargoClass
    {
        public int TariffID { get; set; }
        public string  Name { get; set; }

        public int MaxHours { get; set; }
        public int Transport { get; set; }
        public string MinPrice { get; set; }
        public int Armed { get; set; }
        public string Description { get; set; }
        public int Guards { get; set; }

        public CargoClass(int tar, string name, int maxh, int tran, string mPrice, int armed, string desc, int guards)
        {
            TariffID = tar;
            Name = name;
            MaxHours = maxh;
            Transport = tran;
            MinPrice = mPrice;
            Armed = armed;
            Description = desc;
            Guards = guards;
        }

    }
}
