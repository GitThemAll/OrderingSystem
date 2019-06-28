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
    public partial class orderItemDisplay : UserControl
    {
        OrderProcessingUI orderProcessing;
        OrderItem item;
        DateTime startTime;
        //when created takes a form and an item
        public orderItemDisplay(OrderProcessingUI orderProcessing,OrderItem item,DateTime startTime)
        {
            this.orderProcessing = orderProcessing;
            this.item = item;
            this.startTime = startTime;

            Name_lbl.Text = item.name;
            SubType_lbl.Text = item.subType;
            table_lbl.Text = item.Table_num.ToString();

            InitializeComponent();
        }
        //would add an item to a selection list from the form
        private void selectItem_chkbx_CheckedChanged(object sender, EventArgs e)
        {
            //if (selectItem_chkbx.Checked)
            //{
            //    orderProcessing.AddSelect(item);
            //}
            //else
            //{
            //    orderProcessing.RemoveSelect(item);
            //}
        }

        private void orderItemDisplay_Click(object sender, EventArgs e)
        {
            if (selectItem_chkbx.Checked)
            {
                selectItem_chkbx.Checked = false;
            }
            else
            {
                selectItem_chkbx.Checked = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - startTime;
            if (DateTime.Now.AddMinutes(15) < startTime)
                Time_lbl.ForeColor = Color.Red;
            if (DateTime.Now.AddHours(1) > startTime)
            {
                Time_lbl.Text = span.Minutes.ToString() + ":" + span.Seconds.ToString();
            }
            else
                Time_lbl.Text = "1+ Hours";
        }
    }
}
