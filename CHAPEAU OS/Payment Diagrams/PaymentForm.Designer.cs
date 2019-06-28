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
            this.OrderIdTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BillGridView = new System.Windows.Forms.DataGridView();
            this.TipTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmPaymentButton = new System.Windows.Forms.Button();
            this.PrintBillBtn = new System.Windows.Forms.Button();
            this.PriceNoVatLbl = new System.Windows.Forms.Label();
            this.VatLbl = new System.Windows.Forms.Label();
            this.TotalPriceLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderIdTxtBox
            // 
            this.OrderIdTxtBox.BackColor = System.Drawing.SystemColors.Info;
            this.OrderIdTxtBox.Enabled = false;
            this.OrderIdTxtBox.Location = new System.Drawing.Point(88, 31);
            this.OrderIdTxtBox.Name = "OrderIdTxtBox";
            this.OrderIdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.OrderIdTxtBox.TabIndex = 0;
            this.OrderIdTxtBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "OrderId";
            // 
            // BillGridView
            // 
            this.BillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillGridView.Location = new System.Drawing.Point(34, 65);
            this.BillGridView.Name = "BillGridView";
            this.BillGridView.Size = new System.Drawing.Size(199, 240);
            this.BillGridView.TabIndex = 2;
            // 
            // TipTxtBox
            // 
            this.TipTxtBox.Location = new System.Drawing.Point(141, 388);
            this.TipTxtBox.Name = "TipTxtBox";
            this.TipTxtBox.Size = new System.Drawing.Size(91, 20);
            this.TipTxtBox.TabIndex = 3;
            this.TipTxtBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add a tip:";
            // 
            // ConfirmPaymentButton
            // 
            this.ConfirmPaymentButton.Location = new System.Drawing.Point(34, 414);
            this.ConfirmPaymentButton.Name = "ConfirmPaymentButton";
            this.ConfirmPaymentButton.Size = new System.Drawing.Size(198, 48);
            this.ConfirmPaymentButton.TabIndex = 5;
            this.ConfirmPaymentButton.Text = "Confirm Payment";
            this.ConfirmPaymentButton.UseVisualStyleBackColor = true;
            this.ConfirmPaymentButton.Click += new System.EventHandler(this.ConfirmPaymentBtn_Click);
            // 
            // PrintBillBtn
            // 
            this.PrintBillBtn.Location = new System.Drawing.Point(194, 31);
            this.PrintBillBtn.Name = "PrintBillBtn";
            this.PrintBillBtn.Size = new System.Drawing.Size(54, 22);
            this.PrintBillBtn.TabIndex = 6;
            this.PrintBillBtn.Text = "Print Bill";
            this.PrintBillBtn.UseVisualStyleBackColor = true;
            this.PrintBillBtn.Click += new System.EventHandler(this.PrintBillBtn_Click);
            // 
            // PriceNoVatLbl
            // 
            this.PriceNoVatLbl.AutoSize = true;
            this.PriceNoVatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceNoVatLbl.Location = new System.Drawing.Point(31, 308);
            this.PriceNoVatLbl.Name = "PriceNoVatLbl";
            this.PriceNoVatLbl.Size = new System.Drawing.Size(144, 15);
            this.PriceNoVatLbl.TabIndex = 7;
            this.PriceNoVatLbl.Text = "Total price exclusive VAT:";
            this.PriceNoVatLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // VatLbl
            // 
            this.VatLbl.AutoSize = true;
            this.VatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VatLbl.Location = new System.Drawing.Point(144, 335);
            this.VatLbl.Name = "VatLbl";
            this.VatLbl.Size = new System.Drawing.Size(31, 15);
            this.VatLbl.TabIndex = 8;
            this.VatLbl.Text = "VAT:";
            // 
            // TotalPriceLbl
            // 
            this.TotalPriceLbl.AutoSize = true;
            this.TotalPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLbl.Location = new System.Drawing.Point(74, 360);
            this.TotalPriceLbl.Name = "TotalPriceLbl";
            this.TotalPriceLbl.Size = new System.Drawing.Size(101, 15);
            this.TotalPriceLbl.TabIndex = 9;
            this.TotalPriceLbl.Text = "Total price + VAT:";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 474);
            this.Controls.Add(this.TotalPriceLbl);
            this.Controls.Add(this.VatLbl);
            this.Controls.Add(this.PriceNoVatLbl);
            this.Controls.Add(this.PrintBillBtn);
            this.Controls.Add(this.ConfirmPaymentButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TipTxtBox);
            this.Controls.Add(this.BillGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderIdTxtBox);
            this.Name = "PaymentForm";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrderIdTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BillGridView;
        private System.Windows.Forms.TextBox TipTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConfirmPaymentButton;
        private System.Windows.Forms.Button PrintBillBtn;
        private System.Windows.Forms.Label PriceNoVatLbl;
        private System.Windows.Forms.Label VatLbl;
        private System.Windows.Forms.Label TotalPriceLbl;
    }
}

