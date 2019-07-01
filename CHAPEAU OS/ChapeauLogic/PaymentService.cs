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
        public double priceWithoutVat;

        public double TotalVat { get; private set; }
        public double TotalPrice { get; private set; }

        public List<OrderItem> GetOrderItems(int orderId)
        {
            try
            {
                List<OrderItem> Items = paymentdb.GetOrderItems(orderId);
                calculatePrice(Items);
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

            }

        }

        public void UpdateOrderStatusAndTip(Order o)
        {
            try
            {
                paymentdb.UpdateOrderStatusAndTip(o);
            }
            catch (SystemException ex)
            {
                throw new SystemException("The order couldn't be payed for");
            }
        }

        private void calculatePrice(List<OrderItem> items)
        {
            foreach (OrderItem item in items)
            {
                priceWithoutVat += (double)item.price * item.quantity;
                TotalVat += item.Vat * item.quantity;
            }
            TotalPrice = priceWithoutVat + TotalVat;
        }
    }
}
