using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class EquipClass
    {
        public int EquipID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }

        public EquipClass(int eqID, string name, string model, string desc)
        {
            EquipID = eqID;
            Name = name;
            Model = model;
            Description = desc;
        }
    }
}
