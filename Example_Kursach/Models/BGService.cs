using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class BGService
    {
        public int TariffID { get; set; }
        public string Name { get; set; }
        public int Days { get; set; }
        public int MaxHours { get; set; }

        public string PricePerDay { get; set; }
        public string MonthPrice { get; set; }
        public int Armed { get; set; }
        public int Transport { get; set; }
        public int Guards { get; set; }

        public BGService(int tariff, string name, int days, int maxHours, string dayPrice, string monthPrice, int armed, int transport, int guards)
        {
            TariffID = tariff;
            Name = name;
            Days = days;
            MaxHours = maxHours;
            PricePerDay = dayPrice;
            MonthPrice = monthPrice;
            Armed = armed;
            Transport = transport;
            Guards = guards;

        }

    }
}
