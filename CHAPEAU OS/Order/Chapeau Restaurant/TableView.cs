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

namespace Chapeau_Restaurant
{
    public partial class TableView : UserControl
    {
        DateTime startTime;
        OrderForm orderForm;
        public Order order;
        public TableView(int tableNumber, Status state, string timer, OrderForm orderForm)
        {
            InitializeComponent();
            TableNumber_lbl.Text = tableNumber.ToString();
            TableState_btn.Text = state.ToString();
            Timer_lbl.Text = timer;
            startTime = DateTime.Now;
            this.orderForm = orderForm;
            order = new Order();
            order.table = tableNumber;
        }
        private void timer7_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - startTime;
            if (DateTime.Now.AddMinutes(15) < startTime)
                Timer_lbl.ForeColor = Color.Red;
            if (DateTime.Now.AddHours(1) > startTime)
            {
                Timer_lbl.Text = span.Minutes.ToString() + ":" + span.Seconds.ToString();
            }
            else
                Timer_lbl.Text = "1+ Hours";
        }

        private void TableState_btn_Click(object sender, EventArgs e)
        {
            orderForm.ShowOrderDetails(order);
        }

        public void changestate()
        {
            TableState_btn.Text = order.state.ToString();
            switch (order.state)
            {
                case Status.Occupied:
                    TableState_btn.BackColor = Color.Orange;
                    break;
                case Status.Reserved:
                    TableState_btn.BackColor = Color.Purple;
                    TableState_btn.ForeColor = Color.White;
                    break;
                case Status.Pending:
                    TableState_btn.BackColor = Color.Yellow;
                    break;
                case Status.Processing:
                    TableState_btn.BackColor = Color.Blue;
                    TableState_btn.ForeColor = Color.White;
                    break;
                case Status.Ready:
                    TableState_btn.BackColor = Color.Green;
                    break;
                default:
                    TableState_btn.BackColor = Color.White;
                    break;

            }
            CheckTimer();
        }

        public void CheckTimer()
        {
            if (order.state == Status.Pending || order.state == Status.Processing)
            {
                OrderTimer.Start();
                Timer_lbl.Show();
            }
            else
            {
                OrderTimer.Stop();
                Timer_lbl.Hide();
            }
            }
        }
}
