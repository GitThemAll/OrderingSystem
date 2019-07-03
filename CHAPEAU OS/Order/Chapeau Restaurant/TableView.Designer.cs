namespace Chapeau_Restaurant
{
    partial class TableView
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
            this.TableState_btn = new System.Windows.Forms.Button();
            this.TableNumber_lbl = new System.Windows.Forms.Label();
            this.Timer_lbl = new System.Windows.Forms.Label();
            this.OrderTimer = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TableState_btn
            // 
            this.TableState_btn.BackColor = System.Drawing.Color.White;
            this.TableState_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableState_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableState_btn.Location = new System.Drawing.Point(0, 0);
            this.TableState_btn.Name = "TableState_btn";
            this.TableState_btn.Size = new System.Drawing.Size(150, 90);
            this.TableState_btn.TabIndex = 0;
            this.TableState_btn.Text = "State";
            this.TableState_btn.UseVisualStyleBackColor = false;
            this.TableState_btn.Click += new System.EventHandler(this.TableState_btn_Click);
            // 
            // TableNumber_lbl
            // 
            this.TableNumber_lbl.AutoSize = true;
            this.TableNumber_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNumber_lbl.Location = new System.Drawing.Point(3, 0);
            this.TableNumber_lbl.Name = "TableNumber_lbl";
            this.TableNumber_lbl.Size = new System.Drawing.Size(58, 24);
            this.TableNumber_lbl.TabIndex = 1;
            this.TableNumber_lbl.Text = "Table";
            // 
            // Timer_lbl
            // 
            this.Timer_lbl.AutoSize = true;
            this.Timer_lbl.Location = new System.Drawing.Point(103, 8);
            this.Timer_lbl.Name = "Timer_lbl";
            this.Timer_lbl.Size = new System.Drawing.Size(0, 13);
            this.Timer_lbl.TabIndex = 2;
            // 
            // OrderTimer
            // 
            this.OrderTimer.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Timer_lbl);
            this.Controls.Add(this.TableNumber_lbl);
            this.Controls.Add(this.TableState_btn);
            this.Name = "TableView";
            this.Size = new System.Drawing.Size(150, 90);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TableState_btn;
        private System.Windows.Forms.Label TableNumber_lbl;
        private System.Windows.Forms.Label Timer_lbl;
        private System.Windows.Forms.Timer OrderTimer;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
