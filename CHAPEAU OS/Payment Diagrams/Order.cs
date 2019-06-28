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
        private List<OrderItem> orderItems;
        public int id;
        public DateTime date;
        public Status state;
        public decimal tip;
        public string feedback;
        public int table;

        public Order()
        {
            orderItems = new List<OrderItem>();
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
            if (OrderLines.ContainsKey(itemId))
            {
                quantity = orderLines[itemId].quantity;
            }

            return quantity;
        }

        public void GetState()
        {

        }

        public List<OrderItem> OrderItems
        {
            get
{
                return orderItems;
            }
            set
            {
                
                orderItems = value;
            }
            
        }

        public Dictionary<int, OrderItem> OrderLines
        {
            get
            {
                foreach (OrderItem item in OrderItems)
                {
                    SetOrderLineData(item);
                }
                return orderLines;
            }
        }
    }
}
