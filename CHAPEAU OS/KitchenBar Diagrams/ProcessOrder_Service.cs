using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class ProcessOrder_Service
    {
        ProcessOrder_DAO ProcessOrder_db = new ProcessOrder_DAO();

        public List<OrderItem> Get_All_Orders(bool food) 
        {
            try
            {
                List<OrderItem> OrderItems;
                if (food)
                {
                    OrderItems = ProcessOrder_db.Db_Get_All_Food_Orders();
                }

                else
                    OrderItems = ProcessOrder_db.Db_Get_All_Drink_Orders();

                return OrderItems;
            }
            catch (Exception e)
            {
                throw new Exception("couldn't connect to the database");
            }
        }

        public void Order_Item_Status_Ready(int Order_Id, int Order_Item_Id)
        {
            ProcessOrder_db.DB_Order_Item_Status_Ready( Order_Id,  Order_Item_Id);
        }

        public List<OrderItem> Get_All_READY_Orders(bool food) //for Order History
        {
            try
            {
                List<OrderItem> OrderItems;
                if (food)
                {
                    OrderItems = ProcessOrder_db.Db_Get_All_READY_Food_Orders();
                }

                else
                    OrderItems = ProcessOrder_db.Db_Get_All_READY_Drink_Orders();

                return OrderItems;
            }
            catch (Exception e)
            {
                throw new Exception("couldn't connect to the database");
            }
        }
    }
}


////Orders.Id, MenuItem.Name,MenuItem.Sub_Type, Orders.Time, Orders.[Table],OrderItem.Id 
//public int Order_Id;
//public string Item_name;
//public string Sub_Type;
//public int Table_num;
//public DateTime Time;
//public int Order_Item_Id;
//public int Item_status;


////**************************************** Payment Part ********************************************