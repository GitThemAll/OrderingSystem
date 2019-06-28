using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace Chapeau_Restaurant
{
    public partial class PaymentForm : ChapeauForm
    {
        PaymentService ps;
       public Order order;

       public OrderForm orderForm;
        public PaymentForm(OrderForm orderForm)
        {
            order = new Order();
            InitializeComponent();
            this.orderForm = orderForm;
            PrintBillBtn.Hide();
            ps = new PaymentService();
        }

        private void ConfirmPaymentBtn_Click(object sender, EventArgs e)
        {
            string s = TipTxtBox.Text;
            order.tip = decimal.Parse(s);
            order.feedback = CommentBox.Text;
            Choosepayment choosepayment = new Choosepayment(order,this);
            choosepayment.ShowDialog();
            this.Close();

        }

        private void PrintBillBtn_Click(object sender, EventArgs e)
        {
            PrintBill();
        }
        public void PrintBill()
        {
            OrderIdTxtBox.Text = order.id.ToString();
            int count = 0;
            List<OrderItem> orderItems = ps.GetOrderItems(order.id);
            Double priceWithoutVat = 0, priceWithVat = 0, TotalVat = 0;
           

            foreach (OrderItem orderItem in orderItems)
            {
                BillGridView.Rows.Add();
                BillGridView.Rows[count].Cells[0].Value = orderItem.name;
                BillGridView.Rows[count].Cells[1].Value = orderItem.price;
                BillGridView.Rows[count].Cells[2].Value = orderItem.Vat;
                BillGridView.Rows[count].Cells[3].Value = orderItem.quantity;
                count++;

            }
            
            foreach (OrderItem item in orderItems)
            {
                priceWithoutVat += (double)item.price*item.quantity;
                TotalVat += item.Vat*item.quantity;
            }
            priceWithVat = priceWithoutVat + TotalVat;
            VatLbl.Text += $"   {TotalVat.ToString()}";
            PriceNoVatLbl.Text += $"   {priceWithoutVat.ToString()}";
            TotalPriceLbl.Text +=$"   {priceWithVat.ToString()}";

        }



        private void TipTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            if (c == 46 && TipTxtBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true; return;
            }
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

       

       

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderForm.Show();
            orderForm.LoadTables();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            

        }
    }
}
