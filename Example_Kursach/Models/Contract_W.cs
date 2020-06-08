using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class Contract_W
    {
        public int ContractID { get; set; }
        public int SWorkerID { get; set; }

        public Contract_W(int cID, int sWorker)
        {
            ContractID = cID;
            SWorkerID = sWorker;
        }
    }
}
