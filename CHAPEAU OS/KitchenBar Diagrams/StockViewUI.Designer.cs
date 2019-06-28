namespace Chapeau_Restaurant
{
    partial class StockViewUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StockListView = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem1,
            this.stockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stockToolStripMenuItem1
            // 
            this.stockToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.stockToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.stockToolStripMenuItem1.Name = "stockToolStripMenuItem1";
            this.stockToolStripMenuItem1.Size = new System.Drawing.Size(53, 21);
            this.stockToolStripMenuItem1.Text = "Stock";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.stockToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.stockToolStripMenuItem.Text = "Orders";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // StockListView
            // 
            this.StockListView.Location = new System.Drawing.Point(8, 30);
            this.StockListView.Name = "StockListView";
            this.StockListView.Size = new System.Drawing.Size(350, 401);
            this.StockListView.TabIndex = 8;
            this.StockListView.UseCompatibleStateImageBehavior = false;
            // 
            // StockViewUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 448);
            this.Controls.Add(this.StockListView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StockViewUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockViewUI";
            this.Load += new System.EventHandler(this.StockViewUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ListView StockListView;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem1;
    }
}