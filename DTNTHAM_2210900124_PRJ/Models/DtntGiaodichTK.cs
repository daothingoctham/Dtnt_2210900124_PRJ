using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTNTHAM_2210900124_PRJ.Models
{
    public class DtntGiaodichTK
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
    }
}