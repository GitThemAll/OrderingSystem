namespace Chapeau_Restaurant
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderDetails_menuStrip = new System.Windows.Forms.MenuStrip();
            this.lunchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanelMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMenuItems = new System.Windows.Forms.Panel();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tables_lbl = new System.Windows.Forms.Label();
            this.OrderDetails_menuStrip.SuspendLayout();
            this.pnlMenuItems.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderDetails_menuStrip
            // 
            this.OrderDetails_menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OrderDetails_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.OrderDetails_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lunchToolStripMenuItem,
            this.dinnerToolStripMenuItem,
            this.drinksToolStripMenuItem,
            this.orderDetailsToolStripMenuItem});
            this.OrderDetails_menuStrip.Location = new System.Drawing.Point(0, 114);
            this.OrderDetails_menuStrip.Name = "OrderDetails_menuStrip";
            this.OrderDetails_menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.OrderDetails_menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderDetails_menuStrip.Size = new System.Drawing.Size(361, 24);
            this.OrderDetails_menuStrip.TabIndex = 1;
            this.OrderDetails_menuStrip.Text = "menuStrip1";
            // 
            // lunchToolStripMenuItem
            // 
            this.lunchToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lunchToolStripMenuItem.Name = "lunchToolStripMenuItem";
            this.lunchToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.lunchToolStripMenuItem.Text = "Lunch ";
            this.lunchToolStripMenuItem.Click += new System.EventHandler(this.lunchToolStripMenuItem_Click);
            // 
            // dinnerToolStripMenuItem
            // 
            this.dinnerToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dinnerToolStripMenuItem.Name = "dinnerToolStripMenuItem";
            this.dinnerToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dinnerToolStripMenuItem.Text = "Dinner";
            this.dinnerToolStripMenuItem.Click += new System.EventHandler(this.dinnerToolStripMenuItem_Click);
            // 
            // drinksToolStripMenuItem
            // 
            this.drinksToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            this.drinksToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.drinksToolStripMenuItem.Text = "Drinks";
            this.drinksToolStripMenuItem.Click += new System.EventHandler(this.drinksToolStripMenuItem_Click);
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.orderDetailsToolStripMenuItem.Text = "Order Details ";
            this.orderDetailsToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsToolStripMenuItem_Click);
            // 
            // flowLayoutPanelMenuItems
            // 
            this.flowLayoutPanelMenuItems.AutoScroll = true;
            this.flowLayoutPanelMenuItems.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanelMenuItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMenuItems.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMenuItems.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelMenuItems.Name = "flowLayoutPanelMenuItems";
            this.flowLayoutPanelMenuItems.Size = new System.Drawing.Size(314, 528);
            this.flowLayoutPanelMenuItems.TabIndex = 3;
            this.flowLayoutPanelMenuItems.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelMenuItems_Paint);
            // 
            // pnlMenuItems
            // 
            this.pnlMenuItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenuItems.Controls.Add(this.flowLayoutPanelMenuItems);
            this.pnlMenuItems.Location = new System.Drawing.Point(25, 141);
            this.pnlMenuItems.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenuItems.Name = "pnlMenuItems";
            this.pnlMenuItems.Size = new System.Drawing.Size(314, 528);
            this.pnlMenuItems.TabIndex = 0;
            this.pnlMenuItems.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLunch_Paint);
            // 
            // menuStrip3
            // 
            this.menuStrip3.AutoSize = false;
            this.menuStrip3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip3.BackgroundImage")));
            this.menuStrip3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip3.Size = new System.Drawing.Size(361, 114);
            this.menuStrip3.TabIndex = 5;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Tables_lbl
            // 
            this.Tables_lbl.AutoSize = true;
            this.Tables_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tables_lbl.Location = new System.Drawing.Point(12, 119);
            this.Tables_lbl.Name = "Tables_lbl";
            this.Tables_lbl.Size = new System.Drawing.Size(56, 20);
            this.Tables_lbl.TabIndex = 6;
            this.Tables_lbl.Text = "Tables";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(361, 679);
            this.Controls.Add(this.pnlMenuItems);
            this.Controls.Add(this.OrderDetails_menuStrip);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.Tables_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.OrderDetails_menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderForm";
            this.Text = "Chapeau Restaurant Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.OrderDetails_menuStrip.ResumeLayout(false);
            this.OrderDetails_menuStrip.PerformLayout();
            this.pnlMenuItems.ResumeLayout(false);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip OrderDetails_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem lunchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinksToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuItems;
        private System.Windows.Forms.Panel pnlMenuItems;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label Tables_lbl;
    }
}

