using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQL_Connection.Data
{
    public class Sales
    {
        public string CustomerSalesRep { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public float OrderValue { get; set; }
        public string Status { get; set; }
        public Boolean approved { get; set; }
        public string Territory { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public string PriceListCode { get; set; }
    }
}
