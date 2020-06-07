using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    class SecurityGuard
    {
		public int SWorkerID { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime DoB { get; set; }
		public string Address { get; set; }
		public string PhoneNumber { get; set; }
		public int Rank { get; set; }
		public DateTime LicenseExpDate { get; set; }
		public int UnitID { get; set; }
		public string Position { get; set; }
	}
}
