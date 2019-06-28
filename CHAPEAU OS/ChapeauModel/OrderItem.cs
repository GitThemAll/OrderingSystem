using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapeauModel
{
    public class OrderItem
    {
        //For Kitchen Bar Orders
        public int Order_Id;
        public string Item_name;
        public string Sub_Type;
        public int Table_num;
        public string Time;
        public int Order_Item_Id;
        public Status Item_status;
        //*************************


        public int itemID;//
        public string subType;//
        public string name;//
        public decimal price;
        public string comment;
        public string type;
        public int quantity;
        public int stockQuantity;

        public double Vat
        {
            get
            {
                if (type == "Alcoholic")
                { return (double)price * 0.21; }
                else
                {
                    return (double)price * 0.09;
                }
            }
        }
    }
}