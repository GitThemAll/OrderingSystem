using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace Chapeau_Restaurant
{
    public partial class MenuViewLine : UserControl
    {
        private int quantity = 0;
        public int ItemID;
    
        string name;
        decimal price;
        int stockQuantity;
        OrderForm orderForm;

        public MenuViewLine(OrderItem item, OrderForm orderForm)
        {
            this.orderForm = orderForm;
            InitializeComponent();
            name = item.name;
            lblItemName.Text = name;
            price = item.price;
            lblItemPrice.Text = String.Format("{0:0.00}", price);
            ItemID = item.itemID;
            quantity = item.quantity;
            txtItemQuantity.Text = quantity.ToString();
            stockQuantity = item.stockQuantity;
            UpdateQuantity();
        }

        public bool MarkedForClear { get; set; }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            quantity++;
            UpdateQuantity();
        }

        private void btnSubtractItem_Click(object sender, EventArgs e)
        {
            if (quantity > 0)
            {
                quantity--;
            }
            UpdateQuantity();
        }

        private void UpdateQuantity()
        {
            txtItemQuantity.Text = quantity.ToString();
            OrderItem order = new OrderItem()
            {
                quantity = quantity,
                itemID = ItemID,
                name = name,
                price = price,
                stockQuantity = stockQuantity
            };
            orderForm.DataChanged(order);
            if (quantity >= stockQuantity)
            {
                btnAddItem.Enabled = false;
                MessageBox.Show("Out of stock!", "Alert");
            }
            else
            {
                btnAddItem.Enabled = true;
            }
        }

        private void lblItemPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            quantity = 0;
            UpdateQuantity();
            //if markedforclear is true, the item removes itself
            if (MarkedForClear)
            {
                this.Parent.Controls.Remove(this);
            }
        }

        private void MenuViewLine_Load(object sender, EventArgs e)
        {

        }
    }
}
