namespace Chapeau_Restaurant
{
    partial class Choosepayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choosepayment));
            this.label1 = new System.Windows.Forms.Label();
            this.VisaBtn = new System.Windows.Forms.Button();
            this.CashBtn = new System.Windows.Forms.Button();
            this.AXBtn = new System.Windows.Forms.Button();
            this.PinBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose your payment method";
            // 
            // VisaBtn
            // 
            this.VisaBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.VisaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VisaBtn.BackgroundImage")));
            this.VisaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VisaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisaBtn.Location = new System.Drawing.Point(16, 28);
            this.VisaBtn.Name = "VisaBtn";
            this.VisaBtn.Size = new System.Drawing.Size(376, 149);
            this.VisaBtn.TabIndex = 1;
            this.VisaBtn.UseVisualStyleBackColor = false;
            this.VisaBtn.Click += new System.EventHandler(this.VisaBtn_Click);
            // 
            // CashBtn
            // 
            this.CashBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CashBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CashBtn.BackgroundImage")));
            this.CashBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CashBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CashBtn.FlatAppearance.BorderSize = 10;
            this.CashBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashBtn.Location = new System.Drawing.Point(16, 328);
            this.CashBtn.Name = "CashBtn";
            this.CashBtn.Size = new System.Drawing.Size(376, 149);
            this.CashBtn.TabIndex = 2;
            this.CashBtn.Text = "Cash";
            this.CashBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CashBtn.UseVisualStyleBackColor = false;
            this.CashBtn.Click += new System.EventHandler(this.CashBtn_Click);
            // 
            // AXBtn
            // 
            this.AXBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AXBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AXBtn.BackgroundImage")));
            this.AXBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AXBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AXBtn.Location = new System.Drawing.Point(16, 483);
            this.AXBtn.Name = "AXBtn";
            this.AXBtn.Size = new System.Drawing.Size(376, 140);
            this.AXBtn.TabIndex = 3;
            this.AXBtn.UseVisualStyleBackColor = false;
            this.AXBtn.Click += new System.EventHandler(this.AmericanBtn_Click);
            // 
            // PinBtn
            // 
            this.PinBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PinBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PinBtn.BackgroundImage")));
            this.PinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinBtn.Location = new System.Drawing.Point(16, 183);
            this.PinBtn.Name = "PinBtn";
            this.PinBtn.Size = new System.Drawing.Size(376, 141);
            this.PinBtn.TabIndex = 4;
            this.PinBtn.Text = "Pin";
            this.PinBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PinBtn.UseVisualStyleBackColor = false;
            this.PinBtn.Click += new System.EventHandler(this.PinBtn_Click);
            // 
            // Choosepayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(404, 635);
            this.Controls.Add(this.PinBtn);
            this.Controls.Add(this.AXBtn);
            this.Controls.Add(this.CashBtn);
            this.Controls.Add(this.VisaBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Choosepayment";
            this.Text = "Choosepayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VisaBtn;
        private System.Windows.Forms.Button CashBtn;
        private System.Windows.Forms.Button AXBtn;
        private System.Windows.Forms.Button PinBtn;
    }
}