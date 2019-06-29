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
    public class ProcessOrder_DAO : Base
    {
        public List<OrderItem> Db_Get_All_Food_Orders()
        {
            string query = " SELECT Orders.Id, MenuItem.Name,MenuItem.Sub_Type, Orders.Time, Orders.[Table],OrderItem.Id AS Order_Item_Id " +
                           " FROM Orders " +
                           " JOIN OrderItem ON OrderItem.OrderId = Orders.Id " +
                           " JOIN MenuItem ON MenuItem.Id = OrderItem.ItemId " +
                           " WHERE OrderItem.Item_Status = 'Pending' AND ( MenuItem.Sub_Type <> 'SoftDrinks' AND MenuItem.Sub_Type <> 'HotDrinks' " +
                           " AND MenuItem.Sub_Type <> 'Beers' AND MenuItem.Sub_Type <> 'Wines' ) " +
                           " ORDER BY Orders.Time DESC ";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderItem> Db_Get_All_Drink_Orders()
        {
            string query = " SELECT Orders.Id, MenuItem.Name,MenuItem.Sub_Type, Orders.Time, Orders.[Table],OrderItem.Id AS Order_Item_Id " +
                           " FROM Orders " +
                           " JOIN OrderItem ON OrderItem.OrderId = Orders.Id " +
                           " JOIN MenuItem ON MenuItem.Id = OrderItem.ItemId " +
                           " WHERE OrderItem.Item_Status = 'Pending' AND ( MenuItem.Sub_Type = 'SoftDrinks' OR MenuItem.Sub_Type = 'HotDrinks' " +
                           " OR MenuItem.Sub_Type = 'Beers' OR MenuItem.Sub_Type = 'Wines' ) " +
                           " ORDER BY Orders.Time DESC ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadTables(DataTable dataTable)
        {
            List<OrderItem> OrderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem order = new OrderItem()
                {
                    Order_Id = (int)dr["Id"],
                    Order_Item_Id = (int)dr["Order_Item_Id"],
                    Table_num = (int)dr["Table"],
                    Item_name = Convert.ToString(dr["Name"]),
                    Sub_Type = Convert.ToString(dr["Sub_Type"]),
                    Time = Convert.ToString(dr["Time"])
                };
                OrderItems.Add(order);
            }
            return OrderItems;
        }

        //When one order item is makred as Ready

        public void DB_Order_Item_Status_Ready(int Order_Id, int Order_Item_Id)
        {
            Order_Item_status_Ready(Order_Item_Id);
            Deduct_Quantity_From_Menu_Stock(Order_Item_Id);

            //Checking if WHOLE order is Ready

            if (If_all_Order_Items_Ready(Order_Id))
            {
                Set_Order_Status_Ready(Order_Id);
            }

        }

        void Order_Item_status_Ready(int Id)
        {
            string query = " UPDATE OrderItem SET Item_Status = 'Ready' WHERE Id =  " + Id + "; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        void Deduct_Quantity_From_Menu_Stock(int Id)
        {
            string query = " UPDATE dbo.MenuItem " +
                           " SET Quantity = Quantity - 1 " +
                           " FROM OrderItem " +
                           " JOIN MenuItem ON MenuItem.Id = OrderItem.ItemId " +
                           " WHERE OrderItem.Id = " + Id + "; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        //---

        bool If_all_Order_Items_Ready(int Order_Id)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            orderItems = Get_Order_Item_Status(Order_Id);
            int SameCounter = 0;
            foreach (var item in orderItems)
            {
                if (item.Item_status==Status.Ready)
                {
                    SameCounter++;
                }
            }

            if (SameCounter == orderItems.Count())
                return true;

            return false;

            //for(int I =0; I < orderItems.Count(); I++)
            //{
            //    if (I ==(orderItems.Count() - 1))
            //    {
            //        if ((orderItems[I].Item_status == orderItems[I - 1].Item_status) && orderItems[I].Item_status == Status.Ready)
            //        {
            //            SameCounter++;
            //        }
            //    }
            //    else
            //    {
            //        if ( ( (orderItems[I].Item_status == orderItems[I + 1].Item_status ) && orderItems[I].Item_status == Status.Ready))
            //        {
            //            SameCounter++;
            //        }
            //    }
            //}

        }

        List<OrderItem> Get_Order_Item_Status(int Order_Id)
        {
            string query = " SELECT OrderItem.Item_Status " +
                           " FROM Orders " +
                           " JOIN OrderItem ON OrderItem.OrderId = Orders.Id " +
                           " WHERE OrderItem.OrderId = " + Order_Id + "; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables_Status(ExecuteSelectQuery(query, sqlParameters));
        }

        void Set_Order_Status_Ready(int Id)
        {
            //Set Whole Order Staus to Ready if all Ietms in the Order are Ready
            string query = " UPDATE dbo.Orders " +
                           " SET Status = 'Ready' " +
                           " WHERE Id = " + Id + " ;";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        } 

        private List<OrderItem> ReadTables_Status(DataTable dataTable)
        {
            List<OrderItem> OrderItems_Statuses = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem order = new OrderItem()
                {
                    Item_status = (Status)Enum.Parse(typeof(Status), (string)dr["Item_Status"], true) //(int)dr["Item_Status"]
                };
                OrderItems_Statuses.Add(order);
            }
            return OrderItems_Statuses;
        }

        //Getting all Ready order Items for Order History
        public List<OrderItem> Db_Get_All_READY_Food_Orders()
        {
            string query = " SELECT Orders.Id, MenuItem.Name,MenuItem.Sub_Type, Orders.Time, Orders.[Table],OrderItem.Id AS Order_Item_Id " +
                           " FROM Orders " +
                           " JOIN OrderItem ON OrderItem.OrderId = Orders.Id " +
                           " JOIN MenuItem ON MenuItem.Id = OrderItem.ItemId " +
                           " WHERE OrderItem.Item_Status = 'Ready' AND ( MenuItem.Sub_Type <> 'SoftDrinks' AND MenuItem.Sub_Type <> 'HotDrinks' " +
                           " AND MenuItem.Sub_Type <> 'Beers' AND MenuItem.Sub_Type <> 'Wines' ) " +
                           " ORDER BY Orders.Time DESC ";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderItem> Db_Get_All_READY_Drink_Orders()
        {
            string query = " SELECT Orders.Id, MenuItem.Name,MenuItem.Sub_Type, Orders.Time, Orders.[Table],OrderItem.Id AS Order_Item_Id " +
                           " FROM Orders " +
                           " JOIN OrderItem ON OrderItem.OrderId = Orders.Id " +
                           " JOIN MenuItem ON MenuItem.Id = OrderItem.ItemId " +
                           " WHERE OrderItem.Item_Status = 'Ready' AND ( MenuItem.Sub_Type = 'SoftDrinks' OR MenuItem.Sub_Type = 'HotDrinks' " +
                           " OR MenuItem.Sub_Type = 'Beers' OR MenuItem.Sub_Type = 'Wines' ) " +
                           " ORDER BY Orders.Time DESC ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}

//void Insert_Into_History(int Id)
//{
//    string query = " INSERT INTO OrderHistory(Order_Id, Menu_item_Id) " +
//                   " SELECT OrderId, ItemId " +
//                   " FROM OrderItem " +
//                   " WHERE Id = " + Id + "; ";
//    SqlParameter[] sqlParameters = new SqlParameter[0];
//    ExecuteEditQuery(query, sqlParameters);
//}
