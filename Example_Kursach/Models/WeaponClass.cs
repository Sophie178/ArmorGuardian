using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class WeaponClass
    {
        public int WeaponID { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public WeaponClass(int wId, string model, string desc)
        {
            WeaponID = wId;
            Model = model;
            Description = desc;
        }

    }
}
