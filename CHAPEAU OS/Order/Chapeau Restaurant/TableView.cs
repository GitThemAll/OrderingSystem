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
        OrderForm orderForm;
        public Table table;
        public TableView(Table table, OrderForm orderForm)
        {
            this.table = table;
            InitializeComponent();
            TableNumber_lbl.Text = table.tableNumber.ToString();
            TableState_btn.Text = table.status.ToString();
            this.orderForm = orderForm;
        }
        private void timer7_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - table.order.date;
            if (span > TimeSpan.FromMinutes(15))
                Timer_lbl.ForeColor = Color.Red;
            if (span < TimeSpan.FromHours(1))
            {
                Timer_lbl.Text = span.Minutes.ToString() + ":" + span.Seconds.ToString();
            }
            else
                Timer_lbl.Text = "1+ Hours";
        }

        private void TableState_btn_Click(object sender, EventArgs e)
        {
            orderForm.ShowOrderDetails(table.order);
        }

        public Status CheckState(Status status)
        {
            if (status == Status.Pending)
            {
                int readyCount = 0;
                int totalItems = 0;
                foreach (OrderItem item in table.order.OrderItems)
                {
                    readyCount += orderForm.GetReadyCount(table.order.id, item.itemID);
                    totalItems += item.quantity;
                }
                if (readyCount == totalItems)
                {
                    return Status.Ready;
                }
                else if (readyCount > 0)
                {
                    return Status.Processing;
                }
                return Status.Pending;
            }
            else if (status == Status.Ready)
            {
                return Status.Ready;
            }
            return table.status;
        }
        public void changestate()
        {
            table.status = CheckState(table.order.state);
            TableState_btn.Text = table.status.ToString();

            switch (table.status)
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
                    checkOrderItems();
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

        private void checkOrderItems()
        {
            int readyCount = 0;
            foreach (OrderItem item in table.order.OrderItems)
            {
                if (item.Item_status == Status.Ready)
                    readyCount++;
            }
            if (readyCount > 1)
            {
                TableState_btn.Text += $"\r\n {readyCount} orders ready";
            }
            else if (readyCount == 1)
            {
                TableState_btn.Text += $"\r\n {readyCount} order ready";
            }
        }

        public void CheckTimer()
        {
            if (table.order.state == Status.Pending || table.order.state == Status.Processing)
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
