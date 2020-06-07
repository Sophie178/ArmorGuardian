using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class TechServicesClass
    {
        public int TariffID { get; set; }
        public int MaxRoomSpace { get; set; }
        public string Description { get; set; }
        public string MinPrice { get; set; }
        public string MinMaintenancePrice{ get; set; }

        public TechServicesClass(int tar, int maxRoom, string desc, string minPrice, string minMain)
        {
            TariffID = tar;
            MaxRoomSpace = maxRoom;
            Description = desc;
            MinPrice = minPrice;
            MinMaintenancePrice = minMain;
        }
    }
}
