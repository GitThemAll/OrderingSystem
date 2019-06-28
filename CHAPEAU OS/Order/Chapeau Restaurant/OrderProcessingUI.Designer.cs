namespace Chapeau_Restaurant
{
    partial class OrderProcessingUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderProcessingUI));
            this.OrdStatusbtn = new System.Windows.Forms.Button();
            this.btn_RefreshOrders = new System.Windows.Forms.Button();
            this.listViewORDERS = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdStatusbtn
            // 
            this.OrdStatusbtn.BackColor = System.Drawing.Color.Aqua;
            this.OrdStatusbtn.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdStatusbtn.Location = new System.Drawing.Point(25, 351);
            this.OrdStatusbtn.Name = "OrdStatusbtn";
            this.OrdStatusbtn.Size = new System.Drawing.Size(272, 96);
            this.OrdStatusbtn.TabIndex = 1;
            this.OrdStatusbtn.Text = "CHANGE ORDER STATUS";
            this.OrdStatusbtn.UseVisualStyleBackColor = false;
            this.OrdStatusbtn.Click += new System.EventHandler(this.OrdStatusbtn_Click);
            // 
            // btn_RefreshOrders
            // 
            this.btn_RefreshOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_RefreshOrders.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshOrders.Location = new System.Drawing.Point(303, 351);
            this.btn_RefreshOrders.Name = "btn_RefreshOrders";
            this.btn_RefreshOrders.Size = new System.Drawing.Size(307, 96);
            this.btn_RefreshOrders.TabIndex = 4;
            this.btn_RefreshOrders.Text = "REFRESH ORDERS";
            this.btn_RefreshOrders.UseVisualStyleBackColor = false;
            this.btn_RefreshOrders.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewORDERS
            // 
            this.listViewORDERS.FullRowSelect = true;
            this.listViewORDERS.Location = new System.Drawing.Point(25, 43);
            this.listViewORDERS.Name = "listViewORDERS";
            this.listViewORDERS.Size = new System.Drawing.Size(585, 302);
            this.listViewORDERS.TabIndex = 5;
            this.listViewORDERS.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem,
            this.ordersHistoryToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ordersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // ordersHistoryToolStripMenuItem
            // 
            this.ordersHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ordersHistoryToolStripMenuItem.Name = "ordersHistoryToolStripMenuItem";
            this.ordersHistoryToolStripMenuItem.Size = new System.Drawing.Size(111, 21);
            this.ordersHistoryToolStripMenuItem.Text = "Orders History";
            this.ordersHistoryToolStripMenuItem.Click += new System.EventHandler(this.ordersHistoryToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.stockToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // OrderProcessingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(642, 459);
            this.Controls.Add(this.listViewORDERS);
            this.Controls.Add(this.btn_RefreshOrders);
            this.Controls.Add(this.OrdStatusbtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderProcessingUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderProcessing";
            this.Load += new System.EventHandler(this.OrderProcessingUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OrdStatusbtn;
        private System.Windows.Forms.Button btn_RefreshOrders;
        private System.Windows.Forms.ListView listViewORDERS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersHistoryToolStripMenuItem;
    }
}