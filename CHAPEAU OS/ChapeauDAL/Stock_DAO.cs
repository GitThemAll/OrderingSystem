using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ChapeauModel;

namespace ChapeauDAL
{
    public class Stock_DAO: Base
    {
        public List<Stock> Db_Get_Stock()
        {
            string query = " SELECT Id,Name,Quantity FROM MenuItem ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Stock> ReadTables(DataTable dataTable)
        {
            List<Stock> StockItems = new List<Stock>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Stock stock = new Stock()
                {
                    Id = (int)dr["Id"],
                    Name = Convert.ToString(dr["Name"]),
                    Quantity = Convert.ToString(dr["Quantity"])
                };
                StockItems.Add(stock);
            }
            return StockItems;
        }
    }
}
