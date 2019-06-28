using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class Order_Service
    {
        Order_DAO order_db = new Order_DAO();

        public Order currentOrder = new Order();
        public Order GetChapeauOrder(int tableNumber)
        {
            return order_db.GetChapeauOrder(tableNumber);
        }

        public List<OrderItem> GetOrderItems(int orderId)
        {
            return order_db.GetOrderItems(orderId);
        }

        public List<ChapeauMenuItem> GetChapeauMenuItems(string category, string subCategory)
        {
            List<ChapeauMenuItem> Menuitems = order_db.Db_Menu_Items(category,subCategory);
            return Menuitems;
        }

        public int CreateNewOrder(Order order, int waiterID)
        {
            // Insert empty order
            int id = order_db.Db_Insert_Order(order,waiterID);
            // Returns the ID of the inserted order
            return id;
        }

        public void DeleteCurrentOrder()
        {
            // Delete order
            order_db.Db_Delete_Order(currentOrder.id);
        }

        // Send the order to be updated in the database
        public void SendOrder(int waiterID)
        {
            DeleteCurrentOrder();
            currentOrder.OrderItems = GetOrderLines();
            // call function in the logic layer
            // This function passes:
            // 1. OrderId, which is a unique ID for this order
            // 2. A list of items
            //    Each item in this list has an item id and a quantity

            // Create a unique order ID by using the current time(stamp)
            // PS we know this is not 100% guranateed, but will do for now
            //int orderID = random.Next();
            //SaveOrder(currentOrder,waiterID);
            foreach (OrderItem item in currentOrder.OrderItems)
            {
                for (int i = 0; i < item.quantity; i++)
                {
                    order_db.Db_Insert_Order_Item(currentOrder.id, item.itemID);
                }
            }
        }

        public void CreateNewOrder()
        {
            currentOrder = new Order();
        }

        public List<ChapeauMenuItem> GetMenuItems(string category, string subCategory)
        {
            List<ChapeauMenuItem> chapeauMenuItems = GetChapeauMenuItems(category, subCategory);
            return chapeauMenuItems;
        }

        // Returns te current quantity of the specified item
        public int GetItemQuantity(int itemId)
        {
            int quantity = currentOrder.GetQuantity(itemId);
            return quantity;
        }

        

        public List<OrderItem> GetOrderLines()
        {
            return currentOrder.OrderItems;
        }
    }
}
