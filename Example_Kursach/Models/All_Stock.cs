using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.Models
{
    public class All_Stock
    {
        public int StockID { get; set; }
        public int ItemId { get; set; }
        public int Total { get; set; }
        public int Free { get; set; }
        public int InUse { get; set; }

        public All_Stock(int stock, int item, int total, int free, int inUse)
        {
            StockID = stock;
            ItemId = item;
            Total = total;
            Free = free;
            InUse = inUse;
        }
    }
}
