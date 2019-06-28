using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChapeauModel
{
    public class Order
    {
        //dictionary of items from one order
        private Dictionary<int, OrderItem> orderLines;
        public int id;
        public DateTime date;
        public Status state;
        public decimal tip;
        public string feedback;
        public int table;
        public PaymentType paymentType;

        public Order()
        {
            orderLines = new Dictionary<int, OrderItem>();
        }
        public void SetOrderLineData(OrderItem item)
        {
            orderLines[item.itemID] = item;
        }

        // RETURNS the quantity of the specified item
        public int GetQuantity(int itemId)
        {
            int quantity = 0;
            if (orderLines.ContainsKey(itemId))
            {
                quantity = orderLines[itemId].quantity;
            }

            return quantity;
        }

        public List<OrderItem> OrderItems
        {
            get
{
                List<OrderItem> orderItems=new List<OrderItem>();
                foreach (KeyValuePair<int,OrderItem> item in orderLines)
                    orderItems.Add(item.Value);
                return orderItems;
            }
            set
            {
                foreach (OrderItem item in value)
                    SetOrderLineData(item);
            }
            
        }

        public void CheckOrder(List<OrderItem> orderItems)
        {
            if (orderItems.Count > 0)
            {
                foreach (OrderItem item in orderItems)
                {
                    if (!orderLines.ContainsKey(item.itemID))
                        orderLines.Add(item.itemID, item);
                }
            }
        }
    }
}
