namespace Chapeau_Restaurant
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.OrderIdTxtBox = new System.Windows.Forms.TextBox();
            this.OrderIdLbl = new System.Windows.Forms.Label();
            this.BillGridView = new System.Windows.Forms.DataGridView();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pricee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VATt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantityy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipTxtBox = new System.Windows.Forms.TextBox();
            this.AddTipLbl = new System.Windows.Forms.Label();
            this.ConfirmPaymentButton = new System.Windows.Forms.Button();
            this.PrintBillBtn = new System.Windows.Forms.Button();
            this.PriceNoVatLbl = new System.Windows.Forms.Label();
            this.VatLbl = new System.Windows.Forms.Label();
            this.TotalPriceLbl = new System.Windows.Forms.Label();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CommentBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderIdTxtBox
            // 
            this.OrderIdTxtBox.BackColor = System.Drawing.SystemColors.Info;
            this.OrderIdTxtBox.Cursor = System.Windows.Forms.Cursors.No;
            this.OrderIdTxtBox.Enabled = false;
            this.OrderIdTxtBox.Location = new System.Drawing.Point(74, 94);
            this.OrderIdTxtBox.Name = "OrderIdTxtBox";
            this.OrderIdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.OrderIdTxtBox.TabIndex = 0;
            this.OrderIdTxtBox.Text = "0";
            // 
            // OrderIdLbl
            // 
            this.OrderIdLbl.AutoSize = true;
            this.OrderIdLbl.BackColor = System.Drawing.Color.LightSteelBlue;
            this.OrderIdLbl.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIdLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OrderIdLbl.Location = new System.Drawing.Point(2, 94);
            this.OrderIdLbl.Name = "OrderIdLbl";
            this.OrderIdLbl.Size = new System.Drawing.Size(66, 18);
            this.OrderIdLbl.TabIndex = 1;
            this.OrderIdLbl.Text = "OrderId";
            // 
            // BillGridView
            // 
            this.BillGridView.AllowUserToAddRows = false;
            this.BillGridView.AllowUserToDeleteRows = false;
            this.BillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namee,
            this.Pricee,
            this.VATt,
            this.Quantityy});
            this.BillGridView.Location = new System.Drawing.Point(5, 131);
            this.BillGridView.Name = "BillGridView";
            this.BillGridView.ReadOnly = true;
            this.BillGridView.Size = new System.Drawing.Size(435, 218);
            this.BillGridView.TabIndex = 2;
            // 
            // Namee
            // 
            this.Namee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Namee.FillWeight = 203.0457F;
            this.Namee.HeaderText = "Name";
            this.Namee.Name = "Namee";
            this.Namee.ReadOnly = true;
            // 
            // Pricee
            // 
            this.Pricee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pricee.FillWeight = 65.65144F;
            this.Pricee.HeaderText = "Price";
            this.Pricee.Name = "Pricee";
            this.Pricee.ReadOnly = true;
            // 
            // VATt
            // 
            this.VATt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VATt.FillWeight = 65.65144F;
            this.VATt.HeaderText = "VAT";
            this.VATt.Name = "VATt";
            this.VATt.ReadOnly = true;
            // 
            // Quantityy
            // 
            this.Quantityy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantityy.FillWeight = 65.65144F;
            this.Quantityy.HeaderText = "Quantity";
            this.Quantityy.Name = "Quantityy";
            this.Quantityy.ReadOnly = true;
            // 
            // TipTxtBox
            // 
            this.TipTxtBox.Location = new System.Drawing.Point(385, 468);
            this.TipTxtBox.Name = "TipTxtBox";
            this.TipTxtBox.Size = new System.Drawing.Size(55, 20);
            this.TipTxtBox.TabIndex = 3;
            this.TipTxtBox.Text = "0";
            this.TipTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TipTxtBox_KeyPress);
            // 
            // AddTipLbl
            // 
            this.AddTipLbl.AutoSize = true;
            this.AddTipLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTipLbl.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTipLbl.ForeColor = System.Drawing.Color.Maroon;
            this.AddTipLbl.Location = new System.Drawing.Point(292, 468);
            this.AddTipLbl.Name = "AddTipLbl";
            this.AddTipLbl.Size = new System.Drawing.Size(83, 19);
            this.AddTipLbl.TabIndex = 4;
            this.AddTipLbl.Text = "Add a tip:";
            // 
            // ConfirmPaymentButton
            // 
            this.ConfirmPaymentButton.BackColor = System.Drawing.Color.LightCoral;
            this.ConfirmPaymentButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ConfirmPaymentButton.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPaymentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConfirmPaymentButton.Location = new System.Drawing.Point(37, 505);
            this.ConfirmPaymentButton.Name = "ConfirmPaymentButton";
            this.ConfirmPaymentButton.Size = new System.Drawing.Size(273, 115);
            this.ConfirmPaymentButton.TabIndex = 5;
            this.ConfirmPaymentButton.Text = "Confirm Payment";
            this.ConfirmPaymentButton.UseVisualStyleBackColor = false;
            this.ConfirmPaymentButton.Click += new System.EventHandler(this.ConfirmPaymentBtn_Click);
            // 
            // PrintBillBtn
            // 
            this.PrintBillBtn.BackColor = System.Drawing.Color.LightCoral;
            this.PrintBillBtn.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBillBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrintBillBtn.Location = new System.Drawing.Point(191, 94);
            this.PrintBillBtn.Name = "PrintBillBtn";
            this.PrintBillBtn.Size = new System.Drawing.Size(232, 20);
            this.PrintBillBtn.TabIndex = 6;
            this.PrintBillBtn.Text = "Print Bill";
            this.PrintBillBtn.UseVisualStyleBackColor = false;
            this.PrintBillBtn.Click += new System.EventHandler(this.PrintBillBtn_Click);
            // 
            // PriceNoVatLbl
            // 
            this.PriceNoVatLbl.AutoSize = true;
            this.PriceNoVatLbl.Font = new System.Drawing.Font("Constantia", 12.25F, System.Drawing.FontStyle.Bold);
            this.PriceNoVatLbl.Location = new System.Drawing.Point(161, 367);
            this.PriceNoVatLbl.Name = "PriceNoVatLbl";
            this.PriceNoVatLbl.Size = new System.Drawing.Size(214, 21);
            this.PriceNoVatLbl.TabIndex = 7;
            this.PriceNoVatLbl.Text = "Total price exclusive VAT:";
            // 
            // VatLbl
            // 
            this.VatLbl.AutoSize = true;
            this.VatLbl.Font = new System.Drawing.Font("Constantia", 12.25F, System.Drawing.FontStyle.Bold);
            this.VatLbl.Location = new System.Drawing.Point(330, 397);
            this.VatLbl.Name = "VatLbl";
            this.VatLbl.Size = new System.Drawing.Size(45, 21);
            this.VatLbl.TabIndex = 8;
            this.VatLbl.Text = "VAT:";
            // 
            // TotalPriceLbl
            // 
            this.TotalPriceLbl.AutoSize = true;
            this.TotalPriceLbl.Font = new System.Drawing.Font("Constantia", 12.25F, System.Drawing.FontStyle.Bold);
            this.TotalPriceLbl.Location = new System.Drawing.Point(227, 432);
            this.TotalPriceLbl.Name = "TotalPriceLbl";
            this.TotalPriceLbl.Size = new System.Drawing.Size(148, 21);
            this.TotalPriceLbl.TabIndex = 9;
            this.TotalPriceLbl.Text = "Total price + VAT:";
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
            this.menuStrip3.Size = new System.Drawing.Size(467, 114);
            this.menuStrip3.TabIndex = 11;
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
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(12, 367);
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(143, 132);
            this.CommentBox.TabIndex = 12;
            this.CommentBox.Text = "Add a comment...";
            this.CommentBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CommentBox_MouseClick);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(467, 667);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.TotalPriceLbl);
            this.Controls.Add(this.VatLbl);
            this.Controls.Add(this.PriceNoVatLbl);
            this.Controls.Add(this.PrintBillBtn);
            this.Controls.Add(this.ConfirmPaymentButton);
            this.Controls.Add(this.AddTipLbl);
            this.Controls.Add(this.TipTxtBox);
            this.Controls.Add(this.BillGridView);
            this.Controls.Add(this.OrderIdLbl);
            this.Controls.Add(this.OrderIdTxtBox);
            this.Controls.Add(this.menuStrip3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentForm";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrderIdTxtBox;
        private System.Windows.Forms.Label OrderIdLbl;
        private System.Windows.Forms.DataGridView BillGridView;
        private System.Windows.Forms.TextBox TipTxtBox;
        private System.Windows.Forms.Label AddTipLbl;
        private System.Windows.Forms.Button ConfirmPaymentButton;
        private System.Windows.Forms.Button PrintBillBtn;
        private System.Windows.Forms.Label PriceNoVatLbl;
        private System.Windows.Forms.Label VatLbl;
        private System.Windows.Forms.Label TotalPriceLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pricee;
        private System.Windows.Forms.DataGridViewTextBoxColumn VATt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantityy;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox CommentBox;
    }
}

