using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;



namespace Chapeau_Restaurant
{
    public partial class OrderForm : ChapeauForm
    {
        Font titleFont = new Font("Rockwell", 15, FontStyle.Bold);
        Order_Service order_service = new Order_Service();
        PaymentForm paymentForm;
        List<TableView> tableViews;
        DeviceManager managerForm;

        public OrderForm(DeviceManager managerForm)
        {
            CreateTables();
            InitializeComponent();
            this.managerForm = managerForm;
        }


        private void pnlLunch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lunchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanelMenuItems.Controls.Clear();
            AddMenuSection("Lunch", "Main", "Lunch Main");
            AddMenuSection("Lunch", "Specials", "Specials");
            AddMenuSection("Lunch", "Bites", "Bites");
        }

        private void CreateLunchList()
        {

        }

        private void AddMenuSection(string category, string subCategory, string title)
        {
            List<ChapeauMenuItem> menuItems = order_service.GetMenuItems(category, subCategory);
            AddMenuSectionToUI(menuItems, title);
        }

        //this functions add a section(sub category) to the menu list
        //this will show a title and number of menu lines
        private void AddMenuSectionToUI(List<ChapeauMenuItem> menuItems, string title)
        {
            Label label = new Label();
            label.Text = title;
            label.Font = titleFont;
            flowLayoutPanelMenuItems.Controls.Add(label);


            foreach (ChapeauMenuItem item in menuItems)
            {
                int quantity = currentOrder.GetQuantity(item.itemID);
                OrderItem i = new OrderItem()
                {
                    name = item.name,
                    price = item.price,
                    itemID = item.itemID,
                    quantity = quantity,
                    stockQuantity = item.stockQuantity
                };
                MenuViewLine menuViewLine = new MenuViewLine(i, this);
                flowLayoutPanelMenuItems.Controls.Add(menuViewLine);
            }
        }


        private void flowLayoutPanelMenuItems_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dinnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanelMenuItems.Controls.Clear();
            AddMenuSection("Dinner", "Starters", "Starters");
            AddMenuSection("Dinner", "Main", "Mains");
            AddMenuSection("Dinner", "Desserts", "Desserts");
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanelMenuItems.Controls.Clear();
            AddMenuSection("Drinks", "SoftDrinks", "Soft Drinks");
            AddMenuSection("Drinks", "HotDrinks", "Hot Drinks");
            AddMenuSection("Drinks", "Beers", "Beers");
            AddMenuSection("Drinks", "Wines", "Wines");
        }

        Order currentOrder;
        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrderDetails(currentOrder);
        }

        public void DataChanged(OrderItem order)
        {
            currentOrder.SetOrderLineData(order);
        }

        public void ShowOrderDetails(Order order)
        {
            isOrdersList = false;
            currentOrder = order;
            //
            order_service.currentOrder = order;
            OrderDetails_menuStrip.Show();
            //this will show me the overview of orders. 
            flowLayoutPanelMenuItems.Controls.Clear();
            Label label = new Label();
            label.Width = 300;
            label.Text = "Table " + currentOrder.table;
            label.Font = titleFont;
            flowLayoutPanelMenuItems.Controls.Add(label);

            if (currentOrder.state == Status.Pending || currentOrder.state == Status.Processing || currentOrder.state == Status.Ready)
            {
                //Retrieve all orders from the the model, and show it in the flowlayoutpanel
                foreach (OrderItem item in currentOrder.OrderItems)
                {
                    if (item.quantity != 0)
                    {
                        MenuViewLine menuViewLine = new MenuViewLine(item, this);
                        // We are creating a line for the order details section:
                        // We want these menu view lines to be removed when clicking "X", so mark them
                        menuViewLine.MarkedForClear = true;
                        flowLayoutPanelMenuItems.Controls.Add(menuViewLine);
                    }
                }

                Button btnSendOrder = new Button();
                btnSendOrder.Text = "Send Order";
                flowLayoutPanelMenuItems.Controls.Add(btnSendOrder);
                btnSendOrder.Click += BtnSendOrder_Click;

                Button btnPay = new Button();
                btnPay.Text = "Pay";
                flowLayoutPanelMenuItems.Controls.Add(btnPay);
                btnPay.Click += btnPay_Click;
            }
            else
            {
                Label emptylabel = new Label();
                emptylabel.Text = "order is " + currentOrder.state.ToString();
                emptylabel.Width = 300;
                emptylabel.Height = 50;
                emptylabel.TextAlign = ContentAlignment.MiddleLeft;
                flowLayoutPanelMenuItems.Controls.Add(emptylabel);

                Button newOrder_btn = new Button();
                newOrder_btn.Text = "new order";
                flowLayoutPanelMenuItems.Controls.Add(newOrder_btn);
                newOrder_btn.Click += newOrder_btn_Click;
            }
            if (currentOrder.state == Status.Empty)
            {
                Button occupy_btn = new Button();
                occupy_btn.Text = "occupied";
                flowLayoutPanelMenuItems.Controls.Add(occupy_btn);
                occupy_btn.Click += occupy_btn_Click;
            }
            else if (currentOrder.state == Status.Occupied)
            {
                Button free_btn = new Button();
                free_btn.Text = "free table";
                flowLayoutPanelMenuItems.Controls.Add(free_btn);
                free_btn.Click += free_btn_Click;
            }
        }



        private void OrderIsPending(Order order)
        {
            if ((int)order.state < 3 && order.OrderItems.Count > 0)
                order.state = Status.Pending;
        }

        private void BtnSendOrder_Click(object sender, EventArgs e)
        {
            order_service.SendOrder(currentUser.ID);
            order_service.CreateNewOrder();
            flowLayoutPanelMenuItems.Controls.Clear();
            Label label = new Label();
            label.Width = 200;
            label.Text = "Order Sent!";
            label.Font = titleFont;
            flowLayoutPanelMenuItems.Controls.Add(label);
            managerForm.NotifyScreens();
        }

        // sends order to payment form
        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                paymentForm = new PaymentForm(this);
                paymentForm.order = currentOrder;
                paymentForm.PrintBill();
                paymentForm.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void occupy_btn_Click(object sender, EventArgs e)
        {
            try
            {
                currentOrder.state = Status.Occupied;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void newOrder_btn_Click(object sender, EventArgs e)
        {
            try
            {
                currentOrder.state = Status.Pending;
                currentOrder.date = DateTime.Now;
                int newOrderID = order_service.CreateNewOrder(currentOrder, currentUser.ID);
                currentOrder.id = newOrderID;

                OrderDetails_menuStrip.Show();
                //this will show me the overview of orders. 
                flowLayoutPanelMenuItems.Controls.Clear();
                Label label = new Label();
                label.Width = 300;
                label.Text = "Table " + currentOrder.table;
                label.Font = titleFont;
                flowLayoutPanelMenuItems.Controls.Add(label);

                Label emptylabel = new Label();
                emptylabel.Text = "order is " + currentOrder.state.ToString();
                emptylabel.Width = 300;
                emptylabel.Height = 50;
                emptylabel.TextAlign = ContentAlignment.MiddleLeft;
                flowLayoutPanelMenuItems.Controls.Add(emptylabel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void free_btn_Click(object sender, EventArgs e)
        {
            try
            {
                currentOrder.state = Status.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //*******************************************************************************************
        //Order Overview leveque Jesse
        private void CreateTables()
        {

            int count = 0;
            tableViews = new List<TableView>();
            for (int i = 0; i < 10; i++)
            {
                count++;
                TableView tableview = new TableView(i + 1, Status.Empty, "", this);
                tableViews.Add(tableview);
            }
        }
        public Order GetOrder(int tableNumber)
        {
            return order_service.GetChapeauOrder(tableNumber);
        }

        private void AddOrdersToTables()
        {
            foreach (TableView table in tableViews)
            {
                table.order = GetOrder(table.order.table);
                table.order.OrderItems = getOrderItems(table.order.id);
                table.changestate();
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTables();
        }

        public void LoadTables()
        {
            isOrdersList = true;
            OrderDetails_menuStrip.Hide();
            flowLayoutPanelMenuItems.Controls.Clear();
            flowLayoutPanelMenuItems.WrapContents = true;
            AddOrdersToTables();

            foreach (TableView table in tableViews)
            {
                flowLayoutPanelMenuItems.Controls.Add(table);
            }
        }

        public List<OrderItem> getOrderItems(int orderID)
        {
            return order_service.GetOrderItems(orderID);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }

        bool isOrdersList;
        public override void UpdateScreen()
        {
            if (isOrdersList)
            {
                LoadTables();
            }
        }
    }
}
