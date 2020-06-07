using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class WeaponClass
    {
        public string Model { get; set; }
        public string Description { get; set; }
        public WeaponClass(string model, string desc)
        {
            Model = model;
            Description = desc;
        }

    }
}
