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
                return Items;
            }
            catch (Exception e)
            {
                // something went wrong connecting to the database
                List<OrderItem> Items = new List<OrderItem>();
                OrderItem i = new OrderItem()
                {
                    itemID = -1,
                    name = "üknown????",
                    type = "uknown????",
                };
                Items.Add(i);

                return Items;

                throw new Exception("Application couldn't connect to the database.");
            }

        }

        public void UpdateOrderStatusAndTip(int orderId, decimal tip)
        {
            paymentdb.UpdateOrderStatusAndTip(orderId,tip);
        }
    }
}
