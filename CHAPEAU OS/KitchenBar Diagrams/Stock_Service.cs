using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
   public class Stock_Service
    {
        Stock_DAO Stock_db = new Stock_DAO();

        public List<Stock> Get_Stocks()
        {
            try
            {
                List<Stock> StockItems;
                StockItems = Stock_db.Db_Get_Stock();

                return StockItems;
            }
            catch (Exception e)
            {
                throw new Exception("couldn't connect to the database");
            }
        }
    }
}
