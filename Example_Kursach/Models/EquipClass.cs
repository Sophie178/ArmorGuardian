using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class EquipClass
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }

        public EquipClass( string name, string model, string desc)
        {
            Name = name;
            Model = model;
            Description = desc;
        }
    }
}
