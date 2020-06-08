using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class JPClientsClass
    {
        public string ClientName { get; set; }
        public string TaxRegreasonPoint { get; set; }
        public string TaxReferNumber { get; set; }
        public string Address { get; set; }
        public string PSRN { get; set; }
        public string PhoneNumber { get; set; }
        public string Additional { get; set; }

        public JPClientsClass(string name, string taxreg, string taxref, 
            string address, string psrn, string phone, string add)
        {
            ClientName = name;
            TaxRegreasonPoint = taxreg;
            TaxReferNumber = taxref;
            Address = address;
            PSRN = psrn;
            PhoneNumber = phone;
        }
    }
}
