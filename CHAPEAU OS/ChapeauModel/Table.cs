using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Table
    {
        public Status status;
        public int tableNumber { get; private set; }
        public Order order;

        public Table(int tableNumber, Status status)
        {
            this.status = status;
            this.tableNumber = tableNumber;
            order = new Order();
            order.table = tableNumber;
        }
    }
}
