namespace Chapeau_Restaurant
{
    partial class DeviceManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceManager));
            this.BarmanForm_btn = new System.Windows.Forms.Button();
            this.ChefForm_btn = new System.Windows.Forms.Button();
            this.WaiterForm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BarmanForm_btn
            // 
            this.BarmanForm_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BarmanForm_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BarmanForm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BarmanForm_btn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarmanForm_btn.Location = new System.Drawing.Point(12, 285);
            this.BarmanForm_btn.Name = "BarmanForm_btn";
            this.BarmanForm_btn.Size = new System.Drawing.Size(398, 122);
            this.BarmanForm_btn.TabIndex = 1;
            this.BarmanForm_btn.Text = "Bar Interface";
            this.BarmanForm_btn.UseVisualStyleBackColor = false;
            this.BarmanForm_btn.Click += new System.EventHandler(this.BarmanForm_btn_Click);
            // 
            // ChefForm_btn
            // 
            this.ChefForm_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ChefForm_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChefForm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChefForm_btn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChefForm_btn.Location = new System.Drawing.Point(12, 155);
            this.ChefForm_btn.Name = "ChefForm_btn";
            this.ChefForm_btn.Size = new System.Drawing.Size(398, 112);
            this.ChefForm_btn.TabIndex = 2;
            this.ChefForm_btn.Text = "Kitchen Interface";
            this.ChefForm_btn.UseVisualStyleBackColor = false;
            this.ChefForm_btn.Click += new System.EventHandler(this.ChefForm_btn_Click);
            // 
            // WaiterForm_btn
            // 
            this.WaiterForm_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.WaiterForm_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WaiterForm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WaiterForm_btn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaiterForm_btn.Location = new System.Drawing.Point(12, 22);
            this.WaiterForm_btn.Name = "WaiterForm_btn";
            this.WaiterForm_btn.Size = new System.Drawing.Size(398, 109);
            this.WaiterForm_btn.TabIndex = 3;
            this.WaiterForm_btn.Text = "Waiter Interface";
            this.WaiterForm_btn.UseVisualStyleBackColor = false;
            this.WaiterForm_btn.Click += new System.EventHandler(this.WaiterForm_btn_Click);
            // 
            // DeviceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(422, 419);
            this.Controls.Add(this.WaiterForm_btn);
            this.Controls.Add(this.ChefForm_btn);
            this.Controls.Add(this.BarmanForm_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeviceManager";
            this.Text = "DeviceManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BarmanForm_btn;
        private System.Windows.Forms.Button ChefForm_btn;
        private System.Windows.Forms.Button WaiterForm_btn;
    }
}