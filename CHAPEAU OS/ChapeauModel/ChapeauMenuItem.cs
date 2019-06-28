using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class ChapeauMenuItem
    {
        public int itemID;
        public decimal price;
        //this corresponds to name in stockItem table
        //this is the actual name to be displayed in the UI
        public string name;
        public int stockQuantity;

        public ChapeauMenuItem(int itemID, decimal price, string name,int stockQuantity)
        {
            this.itemID = itemID;
            this.price = price;
            this.name = name;
            this.stockQuantity = stockQuantity;
        }
    }
}
