using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class NPCashless
    {
        public string CardNumber { get; set; }
        public DateTime PaymentDT { get; set; }
        public int NPContractID { get; set; }
        public string PaidAmount { get; set; }

        public NPCashless(string cardnumber,DateTime dateTime, int contract, string amount)
        {
            CardNumber = cardnumber;
            PaymentDT = dateTime;
            NPContractID = contract;
            PaidAmount = amount;
        }
    }
}
