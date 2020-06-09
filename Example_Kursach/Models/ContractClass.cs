using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class ContractClass
    {
        public int ClientID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime DateOfContract { get; set; }
        public int Active { get; set; }
        public string TotalCost { get; set; }
        public int CashPayment { get; set; }
        public int TariffID { get; set; }

        public ContractClass(int client, DateTime start, DateTime end,
            DateTime date, int active, string total, int cash, int tariff)
        {
            ClientID = client;
            Start = start;
            End = end;
            DateOfContract = date;
            Active = active;
            TotalCost = total;
            CashPayment = cash;
            TariffID = tariff;
        }
    }
}
