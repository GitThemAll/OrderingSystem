using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauLogic
{
    public class PaymentService
    {
        Order_DAO paymentdb = new Order_DAO();

        public List<OrderItem> GetOrderItems(int orderId)
        {
            try
            {
                List<OrderItem> Items = paymentdb.GetOrderItems(orderId);

                //foreach (OrderItem item in Items)
                //{
                //    item.quantity = 1;

                //    for (int i = Items.IndexOf(item) + 1; i < Items.Count; i++)
                //    {
                //        if (item.itemID == Items[i].itemID)
                //        {
                //            item.quantity += 1;
                //            Items.RemoveAt(i);


                //        }
                //    }
                //}
                return Items;
            }
            catch (Exception e)
            {
                //something went wrong connecting to the database
                List<OrderItem> Items = new List<OrderItem>();
            OrderItem i = new OrderItem()
            {

                name = "üknown????",
                price = 5,

                    
            };
                Items.Add(i);

                return Items;

                throw new Exception("Application couldn't connect to the database.");
            }

        }

        public void UpdateOrderStatusAndTip(Order o)
        {
            paymentdb.UpdateOrderStatusAndTip(o);
        }
    }
}
