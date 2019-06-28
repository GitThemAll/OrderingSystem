using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace Chapeau_Restaurant
{
    public partial class Choosepayment : Form
    {
        PaymentForm pf;
        PaymentService ps;
        Order Order;
        public Choosepayment(Order o, PaymentForm paymentForm)
        {
            pf = paymentForm;
            InitializeComponent();
            this.Order = o;
        }
        private void PerformPayment()
        {
            ps = new PaymentService();
            ps.UpdateOrderStatusAndTip(this.Order );
            this.Hide();
            pf.orderForm.Show();
            pf.orderForm.LoadTables();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerformPayment();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PerformPayment();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PerformPayment();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PerformPayment();
        }
    }
}
