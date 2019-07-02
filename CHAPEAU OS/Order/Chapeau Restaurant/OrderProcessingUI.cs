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
    public partial class OrderProcessingUI : ChapeauForm
    {
        ProcessOrder_Service ProcessOrder;
        List<OrderItem> All_Order_Items;
        StockViewUI stock;
        DeviceManager managerForm;

        public OrderProcessingUI(string jobType, DeviceManager managerForm)
        {
           // stock.Hide();
            InitializeComponent();
            ProcessOrder = new ProcessOrder_Service();
            this.managerForm = managerForm;
            currentUser = new User();
            currentUser.jobType = jobType;
        }

        private bool IsChef(string jobtype)
        {
            if (jobtype == "Chef")
                return true;
            else
                return false;
        }

        private void OrderProcessingUI_Load(object sender, EventArgs e)
        {
            All_Order_Items = new List<OrderItem>();
            LoadOrdersList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadOrdersList();
        }

        void LoadOrdersList()
        {
            isOrdersList = true;
            btn_RefreshOrders.Show();
            OrdStatusbtn.Show();

            SetHeight(listViewORDERS, 26);

            All_Order_Items = ProcessOrder.Get_All_Orders(IsChef(currentUser.jobType));

            listViewORDERS.Clear();
            listViewORDERS.GridLines = true;
            listViewORDERS.View = View.Details;
            listViewORDERS.Columns.Add("Order ID", 80, HorizontalAlignment.Left);
            listViewORDERS.Columns.Add("Item Name", 200, HorizontalAlignment.Left);
            listViewORDERS.Columns.Add("Sub Type", 100, HorizontalAlignment.Left);
            listViewORDERS.Columns.Add("Table Number", 100, HorizontalAlignment.Left);
            listViewORDERS.Columns.Add("Time", 100, HorizontalAlignment.Left);

            foreach (OrderItem OI in All_Order_Items)
            {
                ListViewItem Ord = new ListViewItem(OI.Order_Id.ToString());
                Ord.Tag = OI;
                Ord.SubItems.Add(OI.Item_name);
                Ord.SubItems.Add(OI.Sub_Type);
                Ord.SubItems.Add(OI.Table_num.ToString());
                Ord.SubItems.Add(OI.Time.Substring(0, 8));
                listViewORDERS.Items.Add(Ord);
            }
            OrdStatusbtn.BackColor = Color.Aqua;
            OrdStatusbtn.Text = "CHANGE ORDER STATUS";

            ordersHistoryToolStripMenuItem.BackColor = SystemColors.Control;
            ordersToolStripMenuItem.BackColor = SystemColors.ActiveBorder;
        }

        private void OrdStatusbtn_Click(object sender, EventArgs e)
        {

            if (listViewORDERS.SelectedItems.Count >= 1)
            {
                for (int i = 0; i < listViewORDERS.SelectedItems.Count; i++)
                {
                    OrderItem OI = (OrderItem)listViewORDERS.SelectedItems[i].Tag;
                    ProcessOrder.Order_Item_Status_Ready(OI.Order_Id,OI.Order_Item_Id);
                }

                OrdStatusbtn.BackColor = Color.LawnGreen;

                if (listViewORDERS.SelectedItems.Count == 1)
                {
                    OrdStatusbtn.Text = "ORDER READY";
                    MessageBox.Show("Selected Order Item was marked as Ready", "Order status changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    OrdStatusbtn.Text = "ORDERS READY";
                    MessageBox.Show("Selected Order Items were marked as Ready", "Order status changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select atleast 1 order to mark as READY", "No Order Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OrdStatusbtn.BackColor = Color.Aqua;
                OrdStatusbtn.Text = "CHANGE ORDER STATUS";
            }

            listViewORDERS.SelectedItems.Clear();
            managerForm.NotifyScreens();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isOrdersList = false;
            stock = new StockViewUI(this);
            stock.Show();
            Hide();
        }

        private void ordersHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isOrdersList = false;
            LoadOrdersHistoryList();
        }

        void LoadOrdersHistoryList()
        {
            btn_RefreshOrders.Hide();
            OrdStatusbtn.Hide();

            SetHeight(listViewORDERS, 26);

            All_Order_Items = ProcessOrder.Get_All_READY_Orders(IsChef(currentUser.jobType));

            listViewORDERS.Clear();
            listViewORDERS.GridLines = true;
            listViewORDERS.View = View.Details;
            listViewORDERS.Columns.Add("Order ID", 80, HorizontalAlignment.Left);
            listViewORDERS.Columns.Add("Item Name", 200, HorizontalAlignment.Left);
            listViewORDERS.Columns.Add("Sub Type", 100, HorizontalAlignment.Left);
            listViewORDERS.Columns.Add("Table Number", 100, HorizontalAlignment.Left);
            listViewORDERS.Columns.Add("Time", 100, HorizontalAlignment.Left);

            foreach (OrderItem OI in All_Order_Items)
            {
                ListViewItem Ord = new ListViewItem(OI.Order_Id.ToString());
                Ord.Tag = OI;
                Ord.SubItems.Add(OI.Item_name);
                Ord.SubItems.Add(OI.Sub_Type);
                Ord.SubItems.Add(OI.Table_num.ToString());
                Ord.SubItems.Add(OI.Time.Substring(0, 8));
                listViewORDERS.Items.Add(Ord);
            }

            ordersToolStripMenuItem.BackColor = SystemColors.Control;
            ordersHistoryToolStripMenuItem.BackColor = SystemColors.ActiveBorder;
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadOrdersList();
        }

        private void SetHeight(ListView listView, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            listView.SmallImageList = imgList;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Logout();
        }


        bool isOrdersList;
        public override void UpdateScreen()
        {
            if (isOrdersList)
            {
                LoadOrdersList();
            }
        }
    }
}
