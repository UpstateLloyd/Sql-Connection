using SQL_Connection.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQL_Connection.IServices
{
    public interface ISalesService
    {
        List<Sales> GetSales();

    }
}
