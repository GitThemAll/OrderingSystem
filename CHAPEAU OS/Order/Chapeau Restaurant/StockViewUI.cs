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
    public partial class StockViewUI : ChapeauForm
    {
        Stock_Service Stocks_controller;
        OrderProcessingUI orderProcessing;
        public StockViewUI(OrderProcessingUI orderProcessing)
        {

            InitializeComponent();
            Stocks_controller = new Stock_Service();
            this.orderProcessing = orderProcessing;
        }

        private void StockViewUI_Load(object sender, EventArgs e)
        {
            LoadOrdersList();
        }
        void LoadOrdersList()
        {
            List<Stock> stock = new List<Stock>();
            stock=Stocks_controller.Get_Stocks();

            SetHeight(StockListView, 26);

            StockListView.Clear();
            StockListView.GridLines = true;
            StockListView.View = View.Details;
            StockListView.Columns.Add("Order ID", 100, HorizontalAlignment.Left);
            StockListView.Columns.Add("Item Name", 150, HorizontalAlignment.Left);
            StockListView.Columns.Add("Quantity", 100, HorizontalAlignment.Left);

            foreach (Stock STk in stock)
            {
                ListViewItem Ord = new ListViewItem(STk.Id.ToString());
                Ord.SubItems.Add(STk.Name);
                Ord.SubItems.Add(STk.Quantity);
                StockListView.Items.Add(Ord);
            }
            
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            orderProcessing.Show();
        }

        private void SetHeight(ListView listView, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            listView.SmallImageList = imgList;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
