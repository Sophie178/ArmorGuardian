using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class JPCashless
    {
        public int JPContract { get; set; }
        public string BIC { get; set; }
        public string TranAcc { get; set; }
        public string CorrAcc { get; set; }
        public DateTime PaymentDT { get; set; }
        public string PaidAmount { get; set; }

        public JPCashless(int contract, string bic, string tranAcc, string corrAcc, DateTime payment, string amount)
        {
            JPContract = contract;
            BIC = bic;
            TranAcc = tranAcc;
            CorrAcc = corrAcc;
            PaymentDT = payment;
            PaidAmount = amount;
        }
    }
}
