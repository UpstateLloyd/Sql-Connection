using Microsoft.Extensions.Configuration;
using SQL_Connection.Data;
using SQL_Connection.IServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;


namespace SQL_Connection.Services
{
    public class SalesService : ISalesService
    {
        List<Sales> _oSales = new List<Sales>();
        Sales _oSale = new Sales();
        private string QueryString = @"USE ActiveM_Upstate SELECT csr, [customer name], salesorders_search.orderdate, [order value], [status], salesorders_search.approved, territory, 
                                    month, year, pricelistcode FROM salesorders_search INNER JOIN estimate ON salesorders_search.estimateid = estimate.estimateid
                                    FULL OUTER JOIN customers ON customers.customerid = estimate.estimateid FULL OUTER JOIN prospects ON prospects.prospectid = estimate.prospectid
                                    WHERE estimate.estimateid IS NOT NULL AND YEAR(salesorders_search.orderdate) > YEAR(GETDATE()) - 1 AND salesorders_search.Approved = 1;";
        public IConfiguration _Configuration { get; set; }
        public string _connectionString = "";
        public SalesService(IConfiguration configuration)
        {
            _Configuration = configuration;
            _connectionString = "Data Source=APP-SRV3\\ACTIVEERP;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        public List<Sales> GetSales()
        {
            _oSales = new List<Sales>();
            using (IDbConnection con=new SqlConnection(_connectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                var oSales = con.Query<Sales>(QueryString).ToList();
                if (oSales != null && oSales.Count() > 0)
                {
                    _oSales = oSales;
                }
            }
            return _oSales;
        }
    }
}
