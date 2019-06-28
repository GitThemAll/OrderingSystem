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
        Order order;

        OrderForm orderForm;
        public PaymentForm(OrderForm orderForm, Order order)
        {
            InitializeComponent();
            PrintBillBtn.Hide();
            this.orderForm = orderForm;
            this.order = order;
            OrderIdTxtBox.Text = order.id.ToString();
            ps = new PaymentService();
            PrintBill();
        }

        private void ConfirmPaymentBtn_Click(object sender, EventArgs e)
        {
            order.tip = decimal.Parse(TipTxtBox.Text);
            ps.UpdateOrderStatusAndTip(order.id, order.tip);
            Choosepayment choosepayment = new Choosepayment();
            choosepayment.ShowDialog();

        }

        private void PrintBillBtn_Click(object sender, EventArgs e)
        {
            PrintBill();
        }
        private void PrintBill()
        {
            BillGridView.AutoGenerateColumns = true;
            BillGridView.DataSource = order.OrderItems;
            BillGridView.Update();
            Double priceNoVat = 0, priceWithVat = 0, Vat = 0;
            foreach (OrderItem item in order.OrderItems)
            {
                priceNoVat += (double)item.price;
                Vat += item.Vat;
            }
            priceWithVat = priceNoVat + Vat;
            VatLbl.Text += Vat.ToString();
            PriceNoVatLbl.Text += priceNoVat.ToString();
            TotalPriceLbl.Text += priceWithVat.ToString();

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
