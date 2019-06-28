namespace Chapeau_Restaurant
{
    partial class MenuViewLine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnSubtractItem = new System.Windows.Forms.Button();
            this.txtItemQuantity = new System.Windows.Forms.TextBox();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAddItem.Location = new System.Drawing.Point(231, 10);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(28, 27);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "+";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnSubtractItem
            // 
            this.btnSubtractItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSubtractItem.Location = new System.Drawing.Point(166, 10);
            this.btnSubtractItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubtractItem.Name = "btnSubtractItem";
            this.btnSubtractItem.Size = new System.Drawing.Size(29, 27);
            this.btnSubtractItem.TabIndex = 2;
            this.btnSubtractItem.Text = "-";
            this.btnSubtractItem.UseVisualStyleBackColor = true;
            this.btnSubtractItem.Click += new System.EventHandler(this.btnSubtractItem_Click);
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtItemQuantity.Location = new System.Drawing.Point(202, 14);
            this.txtItemQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(25, 20);
            this.txtItemQuantity.TabIndex = 3;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.Location = new System.Drawing.Point(126, 16);
            this.lblItemPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(40, 14);
            this.lblItemPrice.TabIndex = 4;
            this.lblItemPrice.Text = "label2";
            this.lblItemPrice.Click += new System.EventHandler(this.lblItemPrice_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnClear.Location = new System.Drawing.Point(263, 10);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(34, 27);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "X";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.BackColor = System.Drawing.SystemColors.Window;
            this.lblItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblItemName.Location = new System.Drawing.Point(2, 13);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblItemName.Multiline = true;
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.ReadOnly = true;
            this.lblItemName.Size = new System.Drawing.Size(119, 35);
            this.lblItemName.TabIndex = 6;
            // 
            // MenuViewLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.txtItemQuantity);
            this.Controls.Add(this.btnSubtractItem);
            this.Controls.Add(this.btnAddItem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuViewLine";
            this.Size = new System.Drawing.Size(300, 47);
            this.Load += new System.EventHandler(this.MenuViewLine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnSubtractItem;
        private System.Windows.Forms.TextBox txtItemQuantity;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox lblItemName;
    }
}
