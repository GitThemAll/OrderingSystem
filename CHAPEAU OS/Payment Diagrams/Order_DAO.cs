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
        public List<Order> GetChapeauOrders()
        {
            string query = String.Format("SELECT Id, Date, Time, Status, Tip, Feedback, [Table] FROM Orders WHERE Status not like 'Payed'");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {

                Order order = new Order()
                {
                    id = (int)dr["Id"],
                    date = (DateTime)dr["Date"] + (TimeSpan)dr["Time"],
                    state = (Status)Enum.Parse(typeof(Status), (string)dr["Status"], true),
                    tip = (decimal)dr["Tip"],
                    feedback = (string)dr["Feedback"],
                    table = (int)dr["Table"]
                };
                orders.Add(order);
            }
            return orders;
        }

        public List<OrderItem> GetOrderItems(int orderId)
        {
            List<OrderItem> items = new List<OrderItem>();
            string query = "SELECT M.id, count(M.id) quantity ,Name,Price,Quantity StockQuantity,Type,Sub_Type,i.OrderId FROM OrderItem I "+
                            "join MenuItem M on M.id = I.ItemId "+
                            $"where i.OrderId = {orderId} "+
                            "group by M.id,Name,Price,Quantity,Type,Sub_Type,i.OrderId";
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
                    quantity = (int)dr["quantity"]
                };
                items.Add(item);

            }
            return items;
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
            string query = String.Format("INSERT INTO OrderItem (OrderId, ItemId) VALUES({0}, {1})", orderId, itemId);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Db_Insert_Order(Order order, int waiterID/*int orderId, DateTime dateTime, int status, decimal tip, string feedback*/)
        {
            string date = string.Format("{0:0000}-{1:00}-{2:00}", order.date.Year, order.date.Month, order.date.Day);
            string time = String.Format("{0:00}:{1:00}:{2:00}", order.date.Hour, order.date.Minute, order.date.Second);

            string query = String.Format("INSERT INTO Orders VALUES({0}, '{1}', '{2}', '{3}', {4}, {5}, '{6}', {7})",
                order.id, date, time, order.state.ToString(), order.table, order.tip, order.feedback, waiterID);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
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
        public List<OrderItem> MakeOrderItemsList(int orderId)
        {
            List<OrderItem> items = new List<OrderItem>();
            string query = $"SELECT Id,Name,Price,Type,Sub_Type FROM MenuItem WHERE Id={FetchOrderItemsIds(orderId)} ";
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
                    subType = (string)(dr["Sub_Type"].ToString())
                };
                items.Add(item);

            }
            return items;

        }

        public void UpdateOrderStatusAndTip(int orderId, decimal tip)
        {
            string query = $"UPDATE Orders SET Status={Status.Payed.ToString()}, Tip={tip} WHERE Id={orderId};";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public string FetchOrderItemsIds(int orderId)
        {
            string query = $"SELECT ItemId FROM OrderItem WHERE OrderId={orderId} ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable datatable = (ExecuteSelectQuery(query, sqlParameters));
            List<int> itemIds = new List<int>();
            foreach (DataRow dr in datatable.Rows)
            {
                int id = (int)dr["ItemId"];

                itemIds.Add(id);
            }
            return MakeSelectQuery(itemIds);
        }
        private string MakeSelectQuery(List<int> itemIds)
        {
            string partOfSelectQuery = "";
            for (int i = 0; i < itemIds.Count; i++)
            {
                if (i == itemIds.Count - 1)
                {
                    partOfSelectQuery += itemIds[i];
                }
                else
                {
                    partOfSelectQuery += itemIds[i] + " OR Id= ";
                }


            }
            return partOfSelectQuery;
        }
    }
}
