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
    public class Order_DAO : Base
    {
        public Order GetChapeauOrder(int tableNumber)
        {
            string query = String.Format($"SELECT Id, Date, Time, Status, Tip, Feedback, [Table] FROM Orders WHERE Status not like 'Payed' AND [Table] = {tableNumber}");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable table = ExecuteSelectQuery(query, sqlParameters);
            Order order;
            if (table.Rows.Count > 0)
            {
                DataRow dr = table.Rows[0];
                    order = new Order()
                    {
                        id = (int)dr["Id"],
                        date = (DateTime)dr["Date"] + (TimeSpan)dr["Time"],
                        state = (Status)Enum.Parse(typeof(Status), (string)dr["Status"], true),
                        tip = (decimal)dr["Tip"],
                        feedback = (string)dr["Feedback"],
                        table = (int)dr["Table"]
                    };
                return order;
            }
            order = new Order();
            order.table = tableNumber;
            return order;
        }

        public List<OrderItem> GetOrderItems(int orderId)
        {
            List<OrderItem> items = new List<OrderItem>();
            string query = "SELECT M.id, count(M.id) quantity ,Name,Price,Quantity StockQuantity,Type,Sub_Type,i.OrderId, i.Item_Status FROM OrderItem I "+
                            "join MenuItem M on M.id = I.ItemId "+
                            $"where i.OrderId = {orderId} "+
                            "group by M.id,Name,Price,Quantity,Type,Sub_Type,i.OrderId,i.Item_Status";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable datatable = (ExecuteSelectQuery(query, sqlParameters));
            foreach (DataRow dr in datatable.Rows)
            {
                OrderItem item = new OrderItem
                {
                    itemID = (int)dr["Id"],
                    name = (string)(dr["Name"].ToString()),
                    price = (decimal)dr["Price"],
                    type = (string)(dr["Type"].ToString()),
                    subType = (string)(dr["Sub_Type"].ToString()),
                    stockQuantity = (int)dr["StockQuantity"],
                    quantity = (int)dr["quantity"],
                    Item_status = (Status)Enum.Parse(typeof(Status), (string)dr["Item_Status"], true)
                };
                items.Add(item);

            }
            return items;
        }

        public int getReadyCount(int orderId,int orderItemId)
        {
            List<OrderItem> items = new List<OrderItem>();
            string query = "SELECT count(I.id) readyCount FROM OrderItem I " +
                            "join Orders O on O.id = I.OrderId " +
                            $"where i.OrderId = {orderId} AND i.id = {orderItemId} AND i.Item_Status = 'Ready' " +
                            "group by i.id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable datatable = (ExecuteSelectQuery(query, sqlParameters));
            if (datatable.Rows.Count > 0)
                return (int)datatable.Rows[0]["readyCount"];
            return 0;
        }

        //new
        public int GetItemQuantity(int itemID,int orderID)
        {
            string query = $"SELECT count(itemId) as quantity FROM OrderItem O WHERE O.OrderId ={orderID} AND O.itemId ={itemID} group by itemId";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable datatable = (ExecuteSelectQuery(query, sqlParameters));
            if (datatable.Rows.Count > 0)
            {
                return (int)datatable.Rows[0]["quantity"];
            }
            return 0;
        }

        public List<ChapeauMenuItem> Db_Menu_Items(string category, string subCategory)
        {
            string query = String.Format("SELECT Id,Name, Price,Quantity FROM MenuItem WHERE Type = '{0}' AND Sub_Type = '{1}'", category, subCategory);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadMenuItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public void Db_Insert_Order_Item(int orderId, int itemId)
        {
            string query = String.Format("INSERT INTO OrderItem VALUES({0}, {1}, 'Pending')", orderId, itemId);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Db_Delete_Order(int orderId)
        {
            string query = String.Format("DELETE FROM OrderItem WHERE OrderId = {0}", orderId);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public int Db_Insert_Order(Order order, int waiterID/*int orderId, DateTime dateTime, int status, decimal tip, string feedback*/)
        {
            string date = string.Format("{0:0000}-{1:00}-{2:00}", order.date.Year, order.date.Month, order.date.Day);
            string time = String.Format("{0:00}:{1:00}:{2:00}", order.date.Hour, order.date.Minute, order.date.Second);

            string query = String.Format("INSERT INTO Orders (date, Time, Status, Tip, Feedback, [Table], Waiter) VALUES ('{0}', '{1}', '{2}', {3}, '{4}', {5}, {6}); SELECT SCOPE_IDENTITY();",
                date, time, order.state.ToString(), order.tip, order.feedback, order.table, waiterID);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            int id = ExecuteScalarQuery(query, sqlParameters);
            return id;
        }

        private List<ChapeauMenuItem> ReadMenuItems(DataTable dataTable)
        {
            List<ChapeauMenuItem> menuItems = new List<ChapeauMenuItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                ChapeauMenuItem menuItem = new ChapeauMenuItem((int)dr["Id"], (decimal)dr["Price"], dr["Name"].ToString(), (int)dr["Quantity"]);
                menuItems.Add(menuItem);
            }
            return menuItems;
        }

        //***********************************
        //Payment
        //public List<OrderItem> MakeOrderItemsList(int orderId)
        //{
        //    List<OrderItem> items = new List<OrderItem>();
        //    string query = $"SELECT * WHERE Id={FetchOrderItemsIds(orderId)} ";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    DataTable datatable = (ExecuteSelectQuery(query, sqlParameters));
        //    foreach (DataRow dr in datatable.Rows)
        //    {
        //        OrderItem item = new OrderItem
        //        {
        //            itemID = (int)dr["Id"],
        //            name = (string)(dr["Name"].ToString()),
        //            price = (decimal)dr["Price"],
        //            type = (string)(dr["Type"].ToString()),
        //            subType = (string)(dr["Sub_Type"].ToString())
        //        };
        //        items.Add(item);

        //    }
        //    return items;

        //}

        public void UpdateOrderStatusAndTip(Order o)
        {
            string query = $"UPDATE Orders SET Status='{Status.Payed.ToString()}', Tip={o.tip},FeedBack='{o.feedback}', PaymentType='{o.paymentType.ToString()}' WHERE Id={o.id};";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        //public string FetchOrderItemsIds(int orderId)
        //{
        //    string query = $"SELECT ItemId FROM OrderItem WHERE OrderId={orderId} ";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    DataTable datatable = (ExecuteSelectQuery(query, sqlParameters));
        //    List<int> itemIds = new List<int>();
        //    foreach (DataRow dr in datatable.Rows)
        //    {
        //        int id = (int)dr["ItemId"];

        //        itemIds.Add(id);
        //    }
        //    return MakeSelectQuery(itemIds);
        //}
        //private string MakeSelectQuery(List<int> itemIds)
        //{
        //    string partOfSelectQuery = "";
        //    for (int i = 0; i < itemIds.Count; i++)
        //    {
        //        if (i == itemIds.Count - 1)
        //        {
        //            partOfSelectQuery += itemIds[i];
        //        }
        //        else
        //        {
        //            partOfSelectQuery += itemIds[i] + " OR Id= ";
        //        }


        //    }
        //    return partOfSelectQuery;
        //}
    }
}
