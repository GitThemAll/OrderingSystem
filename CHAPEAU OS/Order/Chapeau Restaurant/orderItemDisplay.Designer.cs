namespace Chapeau_Restaurant
{
    partial class orderItemDisplay
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
            this.components = new System.ComponentModel.Container();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.SubType_lbl = new System.Windows.Forms.Label();
            this.table_lbl = new System.Windows.Forms.Label();
            this.Time_lbl = new System.Windows.Forms.Label();
            this.selectItem_chkbx = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Location = new System.Drawing.Point(61, 3);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(35, 13);
            this.Name_lbl.TabIndex = 0;
            this.Name_lbl.Text = "Name";
            // 
            // SubType_lbl
            // 
            this.SubType_lbl.AutoSize = true;
            this.SubType_lbl.Location = new System.Drawing.Point(205, 3);
            this.SubType_lbl.Name = "SubType_lbl";
            this.SubType_lbl.Size = new System.Drawing.Size(50, 13);
            this.SubType_lbl.TabIndex = 1;
            this.SubType_lbl.Text = "SubType";
            // 
            // table_lbl
            // 
            this.table_lbl.AutoSize = true;
            this.table_lbl.Location = new System.Drawing.Point(279, 3);
            this.table_lbl.Name = "table_lbl";
            this.table_lbl.Size = new System.Drawing.Size(30, 13);
            this.table_lbl.TabIndex = 2;
            this.table_lbl.Text = "table";
            // 
            // Time_lbl
            // 
            this.Time_lbl.AutoSize = true;
            this.Time_lbl.Location = new System.Drawing.Point(327, 3);
            this.Time_lbl.Name = "Time_lbl";
            this.Time_lbl.Size = new System.Drawing.Size(26, 13);
            this.Time_lbl.TabIndex = 3;
            this.Time_lbl.Text = "time";
            // 
            // selectItem_chkbx
            // 
            this.selectItem_chkbx.AutoSize = true;
            this.selectItem_chkbx.Location = new System.Drawing.Point(40, 3);
            this.selectItem_chkbx.Name = "selectItem_chkbx";
            this.selectItem_chkbx.Size = new System.Drawing.Size(15, 14);
            this.selectItem_chkbx.TabIndex = 4;
            this.selectItem_chkbx.UseVisualStyleBackColor = true;
            this.selectItem_chkbx.CheckedChanged += new System.EventHandler(this.selectItem_chkbx_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // orderItemDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectItem_chkbx);
            this.Controls.Add(this.Time_lbl);
            this.Controls.Add(this.table_lbl);
            this.Controls.Add(this.SubType_lbl);
            this.Controls.Add(this.Name_lbl);
            this.Name = "orderItemDisplay";
            this.Size = new System.Drawing.Size(519, 23);
            this.Click += new System.EventHandler(this.orderItemDisplay_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label SubType_lbl;
        private System.Windows.Forms.Label table_lbl;
        private System.Windows.Forms.Label Time_lbl;
        private System.Windows.Forms.CheckBox selectItem_chkbx;
        private System.Windows.Forms.Timer timer1;
    }
}
