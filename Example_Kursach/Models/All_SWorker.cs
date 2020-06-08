using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class All_SWorker
    {
        public int SWorkerID { get; set; }
        public int ItemId { get; set; }
        public DateTime Received { get; set; }
        public int StockId { get; set; }

        public All_SWorker(int sw, int item, DateTime date, int stock)
        {
            SWorkerID = sw;
            ItemId = item;
            Received = date;
            StockId = stock;
        }
    }
}
